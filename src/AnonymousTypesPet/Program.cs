// See https://aka.ms/new-console-template for more information
using AnonymousTypesPet;

Console.WriteLine("Anonymous Pets");

var pets = new[]
{
    new Pet("Hannibal", PetTypes.Dog, 12),
    new Pet("Black", PetTypes.Cat, 8),
    new Pet("White", PetTypes.Dog, 4),
    new Pet("Red", PetTypes.Dog, 7),
    new Pet("Pink", PetTypes.Dog, 7),
    new Pet("Brown", PetTypes.Dog, 7)
};

// SIMPLE CODE
//var averageWeightsData = pets
//    .GroupBy(pet => pet.Type)
//    .Select(grouping => grouping.Average(pet => pet.Age));

//foreach (var item in averageWeightsData)
//{
//    Console.WriteLine(item);
//}


//MODIFIED CODE USİNG ANONYMOUS TYPE
var averageWeightsData = pets
    .GroupBy(pet => pet.Type)
    .Select(grouping => new
    {
        Type = grouping.Key,
        AgeAverage = grouping.Average(pet=>pet.Age)
    })
    .OrderBy(data => data.AgeAverage);


foreach (var item in averageWeightsData)
{
    Console.WriteLine($"Average age for type {item.Type} is {item.AgeAverage}");
}


Console.ReadLine();
