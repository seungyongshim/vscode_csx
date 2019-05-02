//https://code.visualstudio.com/docs/languages/csharp
//https://github.com/OmniSharp/omnisharp-vscode/issues/1333
#! "net472"
#r "nuget: opencvsharp4, 4.1.0.20190416"
#r "nuget: opencvsharp4.runtime.win, 4.1.0.20190416"

using System;
using OpenCvSharp;

Console.WriteLine("Hello World!");
var a = new Mat("e:/1.png");
