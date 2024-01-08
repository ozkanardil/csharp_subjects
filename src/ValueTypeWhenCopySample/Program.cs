// See https://aka.ms/new-console-template for more information
using ValueTypeWhenCopySample.Assets;

Console.WriteLine("Value type when copy. \n");

int a = 10;
Console.WriteLine($"a variable is {a}  \n");

CopyValueType.CopyValueTypeMethod(a);
Console.WriteLine($"Now, new a variable is {a}  \n");

Console.ReadLine();
