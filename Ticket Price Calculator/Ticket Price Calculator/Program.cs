using System;

class TixketPriceCalculator
{
    static void Main()
    {
        const int standardPrice = 10;
        const int discountedPrice = 7;

        Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

        int ticketPrice;

        if (age >= 65 || age <=12)
        {
            ticketPrice = discountedPrice;
        }
        else { ticketPrice = standardPrice;}

        Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
    }
}

