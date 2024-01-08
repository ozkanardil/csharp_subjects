// See https://aka.ms/new-console-template for more information
Console.WriteLine("Reference type when copied \n");

List<int> listA = new List<int> { 1, 2, 3 };
List<int> listB = listA;

listB.Add(4);

Console.WriteLine($"ListA contains {listA.Count} elements which are {string.Join(", ", listA)} ");
Console.WriteLine($"ListB contains {listB.Count} elements which are {string.Join(", ", listB)} ");