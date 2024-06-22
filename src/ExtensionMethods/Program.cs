// See https://aka.ms/new-console-template for more information
using ExtensionMethods.Assets;
using System;

Console.WriteLine("*** Extension Method Samples ***");


Console.WriteLine("1. String Extensions");
string test = null;
bool result = test.IsNullOrEmpty();
Console.WriteLine(result);

string text = "Hello, how are you today?";
int count = text.WordCount(); // Invokes the extension method
Console.WriteLine(count); // Outputs: 5
Console.WriteLine("\n");

Console.WriteLine("2. DateTime Extension");
DateTime now = DateTime.Now;
string formatted = now.ToFormattedString("yyyy-MM-dd"); 
Console.WriteLine(formatted); // "2024-06-21"
Console.WriteLine("\n");

Console.WriteLine("3. Enumerable Extension");
List<int> numbers = null;
bool isEmpty = numbers.IsNullOrEmpty(); 
Console.WriteLine(isEmpty); // True
Console.WriteLine("\n");

Console.WriteLine("4. LinQ Extension");
var LINQnumbers = new[] { 1, 2, 3, 4, 5 };
var resultLinq = LINQnumbers.WhereNot(n => n % 2 == 0);
Console.Write(string.Join(" - ", resultLinq)); // { 1, 3, 5 }
Console.WriteLine("\n");

Console.WriteLine("5. Collectıon Extension");
var collectionNumbers = new List<int> { 1, 2, 3 };
collectionNumbers.AddRange(new[] { 4, 5, 6 }); // Adds multiple items to the list
Console.Write(string.Join(" - ", collectionNumbers));
Console.WriteLine("\n");

Console.WriteLine("6. Integer Extension");
int resultInt = 5.MultiplyBy(2); 
Console.WriteLine(resultInt); // 10
Console.WriteLine("\n");
