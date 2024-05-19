// See https://aka.ms/new-console-template for more information
using ReferenceTypeSample.Assets;

Console.WriteLine("Reference type sample! \n");

var list = new List<int>();    
Console.WriteLine($"List contains {list.Count} elements \n");

ListContainer.AddOneToList(list);
Console.WriteLine($"Now, list contains {list.Count} elements \n");

Console.ReadLine();
