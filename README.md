```
PS C:\workspace\fsharp\FSharpNETCoreSandbox> dotnet --info
.NET Command Line Tools (1.0.0-rc4-004771)

Product Information:
 Version:            1.0.0-rc4-004771
 Commit SHA-1 hash:  d881d45b75

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.14393
 OS Platform: Windows
 RID:         win10-x64
```

```
PS C:\workspace\fsharp\FSharpNETCoreSandbox\CsNETCore> dotnet restore
PS C:\workspace\fsharp\FSharpNETCoreSandbox\CsNETCore> dotnet build
Microsoft (R) Build Engine version 15.1.545.13942
Copyright (C) Microsoft Corporation. All rights reserved.

Sandbox.cs(10,24): error CS0117: 'FSharpType' does not contain a definition for 'IsRecord' [C:\workspace\fsharp\FSharpNE
TCoreSandbox\CsNETCore\CsNETCore.csproj]

Build FAILED.

Sandbox.cs(10,24): error CS0117: 'FSharpType' does not contain a definition for 'IsRecord' [C:\workspace\fsharp\FSharpNE
TCoreSandbox\CsNETCore\CsNETCore.csproj]
    0 Warning(s)
    1 Error(s)

Time Elapsed 00:00:01.44
```

```
PS C:\workspace\fsharp\FSharpNETCoreSandbox\CsNET45> dotnet restore
PS C:\workspace\fsharp\FSharpNETCoreSandbox\CsNET45> dotnet build
Microsoft (R) Build Engine version 15.1.545.13942
Copyright (C) Microsoft Corporation. All rights reserved.

  CsNET45 -> C:\workspace\fsharp\FSharpNETCoreSandbox\CsNET45\bin\Debug\net45\CsNET45.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.64
```

```
PS C:\workspace\fsharp\FSharpNETCoreSandbox\FsNETCore> dotnet restore
PS C:\workspace\fsharp\FSharpNETCoreSandbox\FsNETCore> dotnet build
Microsoft (R) Build Engine version 15.1.545.13942
Copyright (C) Microsoft Corporation. All rights reserved.

  FsNETCore -> C:\workspace\fsharp\FSharpNETCoreSandbox\FsNETCore\bin\Debug\netstandard1.6\FsNETCore.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:06.19
```
