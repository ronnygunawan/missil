[![NuGet](https://img.shields.io/nuget/v/RG.Missil.svg)](https://www.nuget.org/packages/RG.Missil/)

# Missil - MSIL Emit Helper

Installation:
```
Install-Package RG.Missil
```

Usage:
```csharp
using Missil;

ilGenerator
    .Ldarg_1()
    .Dup()
    .Mul()
    .Ldc_I4_2()
    .Add()
    .Ret();
```

