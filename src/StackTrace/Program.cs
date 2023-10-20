// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is stack trace?");

FirstMethod();

static void FirstMethod()
{
    Console.WriteLine("In first method");
    SecondMethod();
}

static void SecondMethod()
{
    Console.WriteLine("In second method");
    ThirdMethod();
}

static void ThirdMethod()
{
    Console.WriteLine("In third method");
    Console.WriteLine(Environment.StackTrace);
    Console.WriteLine();
}
