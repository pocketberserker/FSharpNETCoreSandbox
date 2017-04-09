```
> dotnet --info
.NET Command Line Tools (1.0.0)

Product Information:
 Version:            1.0.0
 Commit SHA-1 hash:  e53429feb4

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.14393
 OS Platform: Windows
 RID:         win10-x64
```

```
> cd .\Test
> dotnet restore
> dotnet test
Build started, please wait...
Build completed.

Test run for .\FSharpNETCoreSandbox\Test\bin\Debug\netcoreapp1.1\Test.dll(.NETCoreApp,Version=v1.1)
Microsoft (R) Test Execution Command Line Tool Version 15.0.0.0
Copyright (c) Microsoft Corporation.  All rights reserved.

...


module: int value, 1
module: string value, string
module: record, null
module: struct record, {V = 0;}
static property: record, {V = 1;}
static property: struct record, {V = 1;}
```
