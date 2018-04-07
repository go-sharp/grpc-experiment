#!/bin/sh

echo "Generating C# assets"
$PROTOC_PATH/protoc --csharp_out=./src/grpc-service --grpc_out=./src/grpc-service  --plugin=protoc-gen-grpc=$PROTOC_PATH/grpc_csharp_plugin ./src/protobuf/todo.proto
echo "Generating GRPC Proxy"
$PROTOC_PATH/protoc -I ./src/protobuf  --go_out=plugins=grpc:./src/grpc-proxy/grpcproxy ./src/protobuf/proxy.proto
$PROTOC_PATH/protoc -I ./src/protobuf  --grpc-gateway_out=logtostderr=true:./src/grpc-proxy/grpcproxy ./src/protobuf/proxy.proto
echo "Generating GRPC Proxy Swagger definiton"
$PROTOC_PATH/protoc -I ./src/protobuf  --swagger_out=logtostderr=true:./src/grpc-proxy ./src/protobuf/proxy.proto