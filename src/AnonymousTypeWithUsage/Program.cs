// See https://aka.ms/new-console-template for more information
Console.WriteLine("Anonymous Type With Usage \n");

var someData = new { number = 5, text = "My name is Ozkan'" };
var changedData = someData with { number = 10 };

Console.WriteLine($"SomeData values: number = {someData.number}, text = {someData.text}) \n");
Console.WriteLine($"ChangedData values: number = {changedData.number}, text = {changedData.text})");

Console.ReadLine();