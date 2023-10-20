// See https://aka.ms/new-console-template for more information
Console.WriteLine("Throw Ex Sample");

try
{
    MethodThrowEx();
}
catch (Exception ex)
{
    Console.WriteLine("Throw Ex");
    Console.WriteLine("Exception caught, logging some information. Stack trace; \n");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine();

    throw;
}

void MethodThrowEx()
{
    try
    {
        var collection = Enumerable.Empty<int>();
        var first = collection.First();
    }
    catch (Exception ex)
    {
        throw ex;
    }
}
