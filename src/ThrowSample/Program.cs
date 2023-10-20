// See https://aka.ms/new-console-template for more information
Console.WriteLine("Throw sample");

try
{
    MethodThrow();
}
catch (Exception ex)
{
    Console.WriteLine("Throw");
    Console.WriteLine("Exception caught, logging some information. Stack trace; \n");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine();

    throw;
}

void MethodThrow()
{
    try
    {
        var collection = Enumerable.Empty<int>();
        var first = collection.First();
    }
    catch (Exception ex)
    {
        throw;
    }
}
