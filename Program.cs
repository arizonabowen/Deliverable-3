/* Name: Jacqelyn Bowen
 * Date: 01/31/2023
 * Description: C# Program utilizing while loops to display the odd/even numbers 
 * between 0 and the number input by the user.
*/ 

using System;
using System.ComponentModel;

namespace Deliverable__3_;
class Program
{
    static void Main(string[] args)
    {
        //defining int and string
        int input = 0;
        string series = "";

        //while loop to display the message until an integer between 1 and 100 is input by the user
        while (true)
        {
            Console.Write("Enter an integer number between 1 and 100: ");
            input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 100)
            {
                break; //once a number between 1 and 100 is input by user, the while loop breaks

            }

        }

        //while loop to display the message until the user enters even/odd or Even/Odd
        while (true)
        {
            Console.Write("Specify the series type (Even or Odd): ");
            series = Console.ReadLine();

            if (series == "Even" || series == "even" || series == "Odd" || series == "odd")
            {
                break; //while loop breaks when these words are input by the user
            }
        }

        //if statement to determine if the odd numbers are to be displayed with the message, based off of the user's previous input
        if (series == "Odd" || series == "odd")
        {
            Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
            for (int i = 1; i <= input; i = i + 2) //For loop that generates all of the odd numbers beween 0 and the input by the user
            {
                Console.WriteLine(i); // lists all of the outputs of i (all of the odd numbers)
            }
        }

        //if statement to determine if the even numbers are to be displayed with the message, based off of the user's previous input
        if (series == "Even" || series == "even")
        {
            Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
            for (int i = 0; i <= input; i = i + 2) //For loop that generates all of the even numbers beween 0 and the input by the user
            {
                Console.WriteLine(i); // lists all of the outputs of i (all of the even numbers)
            }
        }

    }
}

