// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using ValueTypeAsParameterSample.Assets;

Console.WriteLine("Value type as parameter. \n");

int a = 10;
Console.WriteLine($"a variable is {a}  \n");

Caculator.AddOne(a);
Console.WriteLine($"Now, new a variable is {a}  \n");

Console.ReadLine();
