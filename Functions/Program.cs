


while (true)
{
    Console.WriteLine("Tuled või lähed? (in/out)");
    string Choice = Console.ReadLine();
    if (Choice == "in" )
    {
    PrintHello();
        break;
    }
else if (Choice == "out" )
    {
    PrintGoodBye();
        break;  
    }
else
    {
    Console.WriteLine("Proovi uuesti");
    }
 }





    static void PrintHello()
{
    Console.WriteLine("Hello");
}

static void PrintGoodBye()
{ 
    Console.WriteLine("Aidaa");
}