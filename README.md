# grpc-experiment

Example Project GRPC + .Net + grpc-proxy + Reactjs

## Starting experiment

Restore and starting the grpc-server and proxy with the following commands:

```bash
npm i
npm run restore-all
npm run start-macos # According your os start-linux, start-windows
```

Starting the grpc-client with the following command:

```bash
npm run start-client
```

# Development requirements

* .Net Core 2.0
* Nodejs
* Java (Swagger -> Typescript Generation)
* Go (grpc-proxy compilation)

#### Optional

* Protoc (required binaries already in the repo)

## Nuget Requriements for Grpc

### grpc-server

```xml
    <PackageReference Include="Google.Protobuf" Version="3.5.1" />
    <PackageReference Include="Grpc.Core" Version="1.10.0" />
    <PackageReference Include="Grpc.Tools" Version="1.10.0" />
```

## Generating Code

### Generate C# Code

```bash
 protoc --csharp_out=grpc-service --grpc_out=grpc-service  --plugin=protoc-gen-grpc=grpc_csharp_plugin ./protobuf/todo.proto
```

### Proxy Generation

Requirments:

```bash
go get -u github.com/grpc-ecosystem/grpc-gateway/protoc-gen-grpc-gateway
go get -u github.com/grpc-ecosystem/grpc-gateway/protoc-gen-swagger
go get -u github.com/golang/protobuf/protoc-gen-go
```

```bash
# Service generation
../tools/macosx_x64/protoc -I ./protobuf  --go_out=plugins=grpc:./grpc-proxy/grpcproxy ./protobuf/todo.proto
# Proxy Gateway generation
../tools/macosx_x64/protoc -I ./protobuf  --grpc-gateway_out=logtostderr=true:./grpc-proxy/grpcproxy ./protobuf/todo.proto
# Swagger generation
../tools/macosx_x64/protoc -I ./protobuf  --swagger_out=logtostderr=true:./grpc-proxy ./protobuf/todo.proto
```

### Typescript Generation

```bash
java -jar ./tools/swagger-codegen-cli-2.2.1.jar  generate -i ./src/grpc-proxy/proxy.swagger.json -l typescript-fetch -o temp
```

Copy the `api.ts` from `./temp` to `./src/webapp/api` and add line `/* tslint:disable */` at the top of the file.

### References

* [RPC Http Rules](https://cloud.google.com/service-management/reference/rpc/google.api#http)
