# RestSharp.Newtonsoft.Json.Extensions

[![Nuget Version](https://img.shields.io/nuget/v/RestSharp.Newtonsoft.Json.Extensions)](https://www.nuget.org/packages/RestSharp.Newtonsoft.Json.Extensions/)
[![Nuget Download](https://img.shields.io/nuget/dt/RestSharp.Newtonsoft.Json.Extensions)](https://www.nuget.org/packages/RestSharp.Newtonsoft.Json.Extensions/)
[![AppVeyor branch](https://img.shields.io/appveyor/ci/i4004/restsharp-newtonsoft-json-extensions/master)](https://ci.appveyor.com/project/i4004/restsharp-newtonsoft-json-extensions)
[![Libraries.io dependency status for latest release](https://img.shields.io/librariesio/release/nuget/RestSharp.Newtonsoft.Json.Extensions)](https://libraries.io/nuget/RestSharp.Newtonsoft.Json.Extensions)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/i4004/RestSharp.Newtonsoft.Json.Extensions)](https://www.codefactor.io/repository/github/i4004/RestSharp.Newtonsoft.Json.Extensions)
![Platform](https://img.shields.io/badge/platform-.NET%20Standard%202.0%20%7C%20.NET%204.5.2-lightgrey)

`RestSharp.Newtonsoft.Json.Extensions` - is an extensions for RestSharp to use Newtonsoft.Json for serialization/deserialization.

## Usage

### Registration for serialization

```csharp
IRestRequest request = /* ... */;
request.UseNewtonsoftJsonSerializer();
```

### Registration for deserialization

```csharp
IRestClient сlient = /* ... */;
client.UseNewtonsoftJsonDeserializer();
```
