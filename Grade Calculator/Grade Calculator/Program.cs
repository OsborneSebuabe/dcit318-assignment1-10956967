using System;

class GradeConverter
{
    static void Main()
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        int grade =
            Convert.ToInt32(Console.ReadLine());

        if (grade >= 90) 
        {
            Console.WriteLine("The letter grade is A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("The letter grade is B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("The letter grade is C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("The letter grade is D");
        }
        else 
        {
            Console.WriteLine("The letter grade is F");
        }
    }
}

