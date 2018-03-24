# grpc-experiment
Example Project GRPC + .Net + grpc-proxy + Reactjs



## Generating Code

### Generate C# Code
```bash
 protoc --csharp_out=grpc-server --plugin=protoc-gen-grpc=grpc_csharp_plugin ./protobuf/todo.proto
```