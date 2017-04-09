using System;

class FizzBuzz 
{
    static void Main()
    {
        Console.WriteLine("What's your number?");
        string userNumberString = Console.ReadLine();
        int userNumberInt = int.Parse(userNumberString);

        for (int index = 0; index < userNumberInt; index++)
        {
            if ((index % 3 == 0) && (index % 5 != 0))
            {
                Console.WriteLine("Fizz");
            }
            else if ((index % 5 == 0) && (index % 3 != 0))
            {
                Console.WriteLine("Buzz");
            }
            else if ((index % 3 == 0) && (index % 5 == 0))
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}