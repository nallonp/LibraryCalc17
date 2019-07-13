# LibraryCalc17
Biblioteca de operações matemáticas.

[![Build status](https://ci.appveyor.com/api/projects/status/ar1isawbt4yx6n1q/branch/master?svg=true)](https://ci.appveyor.com/project/nallonp/librarycalc17-l7698/branch/master)

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc17.svg)

##  How to install
Install-Package LibraryCalc17 -Version 1.0.4

##  How to use

```cs

using LibraryCalc17;

namespace Example {
  class Program {
    static void Main(string[] args){
      var multiplicacao = new Multiplicacao();
      multiplicacao.Calcula(7, 8);
    }
  }
}
```
