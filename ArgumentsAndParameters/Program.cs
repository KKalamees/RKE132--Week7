
Console.WriteLine("Sisesta sõna");
string userInput = Console.ReadLine();

PrintAny(userInput);

static void PrintAny(string anyString)
{ 
    anyString = anyString.ToUpper();
    for(int i= 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}