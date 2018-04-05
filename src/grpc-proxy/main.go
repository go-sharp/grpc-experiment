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
	dispatcher.Handle("/v1/", http.HandlerFunc(func(w http.ResponseWriter, r *http.Request) {
		// This is important to getting fetch working with cors from the localhost
		w.Header().Set("Access-Control-Allow-Origin", "*")
		w.Header().Set("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS, HEAD")
		w.Header().Set("Access-Control-Allow-Headers", "Access-Control-Request-Method, Content-Type")
		w.Header().Set("Content-Security-Policy", "default-src '*'")
		if r.Method == http.MethodOptions {
			w.WriteHeader(200)
			return
		}
		mux.ServeHTTP(w, r)
	}))
	dispatcher.Handle("/swagger/", http.StripPrefix("/swagger", http.FileServer(http.Dir("./swagger"))))
	dispatcher.HandleFunc("/swagger.json", func(w http.ResponseWriter, r *http.Request) {
		content, err := ioutil.ReadFile("./proxy.swagger.json")
		if err != nil {
			fmt.Fprintf(w, "%v", err)
			return
		}
		w.Write(content)
	})

	log.Printf("starting grpc proxy on port :8080...")
	return http.ListenAndServe(":8080", dispatcher)
}

func main() {
	flag.Parse()

	if err := run(); err != nil {
		log.Fatal(err)
	}
}
