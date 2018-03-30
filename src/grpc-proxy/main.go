package main

import (
	"flag"
	"fmt"
	"io/ioutil"
	"log"
	"net/http"

	"github.com/grpc-ecosystem/grpc-gateway/runtime"
	"golang.org/x/net/context"
	"google.golang.org/grpc"

	gw "./grpcproxy"
)

var (
	echoEndpoint = flag.String("echo_endpoint", "localhost:5000", "endpoint of YourService")
)

func run() error {
	ctx := context.Background()
	ctx, cancel := context.WithCancel(ctx)
	defer cancel()

	mux := runtime.NewServeMux()
	opts := []grpc.DialOption{grpc.WithInsecure()}
	err := gw.RegisterTodoServiceHandlerFromEndpoint(ctx, mux, *echoEndpoint, opts)
	if err != nil {
		return err
	}

	dispatcher := http.NewServeMux()
	dispatcher.Handle("/v1/", mux)
	dispatcher.Handle("/swagger/", http.StripPrefix("/swagger", http.FileServer(http.Dir("./swagger"))))
	dispatcher.HandleFunc("/swagger.json", func(w http.ResponseWriter, r *http.Request) {
		content, err := ioutil.ReadFile("./todo.swagger.json")
		if err != nil {
			fmt.Fprintf(w, "%v", err)
			return
		}
		w.Write(content)
	})
	// swaggerUI := http.FileServer(http.Dir("./swagger"))

	// handler := http.HandlerFunc(func(w http.ResponseWriter, r *http.Request) {
	// 	if r.ProtoMajor == 2 && r.Header.Get("Content-Type") == "application/grpc" {
	// 		mux.ServeHTTP(w, r)
	// 	} else if r.URL.Path == "/swagger.json" {
	// 		content, err := ioutil.ReadFile("./todo.swagger.json")
	// 		if err != nil {
	// 			fmt.Fprintf(w, "%v", err)
	// 			return
	// 		}
	// 		w.Write(content)
	// 	} else {
	// 		swaggerUI.ServeHTTP(w, r)
	// 	}
	// })

	log.Printf("starting grpc proxy on port :8080...")
	return http.ListenAndServe(":8080", dispatcher)
}

func main() {
	flag.Parse()

	if err := run(); err != nil {
		log.Fatal(err)
	}
}
