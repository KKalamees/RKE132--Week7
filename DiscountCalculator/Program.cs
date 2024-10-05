
Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());

double discount = Discount(userInput);
Console.WriteLine("Soodukas on "+ discount + "%");

double newTotal = CalcNewTotal(userInput, discount);
Console.WriteLine("Uus summa "+ discount+"%-ga: "+ newTotal );
static double Discount(int total)
{ 
    if(total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalcNewTotal(double total, double discount)
{ 
    double result = total - ((total * discount) / 100);
    return result;
}
