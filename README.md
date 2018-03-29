# grpc-experiment
Example Project GRPC + .Net + grpc-proxy + Reactjs


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