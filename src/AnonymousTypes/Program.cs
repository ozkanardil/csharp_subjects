// See https://aka.ms/new-console-template for more information
Console.WriteLine("Anonymous Employee");

var employee = new { Name = "Jack", State = "Boston", Age = 43 };

Console.WriteLine($"This person's name is {employee.Name}, he lives in {employee.State} and is {employee.Age} years old.");

// Since anonymous types are read-only, it is not possible to update it.
// If you uncomment the line below, the compiler will alert you.
//employee.Name = "Mark.";

Console.Read();