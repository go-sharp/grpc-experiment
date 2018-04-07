#!/bin/sh

echo "Generating C# assets"
$PROTOC_PATH/protoc --csharp_out=./src/grpc-service --grpc_out=./src/grpc-service  --plugin=protoc-gen-grpc=$PROTOC_PATH/grpc_csharp_plugin ./src/protobuf/todo.proto
echo "Generating GRPC Proxy"
$PROTOC_PATH/protoc -I ./src/protobuf  --go_out=plugins=grpc:./src/grpc-proxy/grpcproxy --plugin=protoc-gen-go=$PROTOC_PATH/protoc-gen-go ./src/protobuf/proxy.proto
$PROTOC_PATH/protoc -I ./src/protobuf  --grpc-gateway_out=logtostderr=true:./src/grpc-proxy/grpcproxy --plugin=protoc-gen-grpc-gateway=$PROTOC_PATH/protoc-gen-grpc-gateway ./src/protobuf/proxy.proto
echo "Generating GRPC Proxy Swagger definiton"
$PROTOC_PATH/protoc -I ./src/protobuf  --swagger_out=logtostderr=true:./src/grpc-proxy --plugin=protoc-gen-swagger=$PROTOC_PATH/protoc-gen-swagger ./src/protobuf/proxy.proto
echo "Generating Typescript-fetch client"
java -jar ./tools/swagger-codegen-cli-2.2.1.jar  generate -i ./src/grpc-proxy/proxy.swagger.json -l typescript-fetch -o temp
echo "/* tslint:disable */" > ./src/webapp/src/api/api.ts
cat ./temp/api.ts >> ./src/webapp/src/api/api.ts
rm -rf ./temp