using System;

namespace CallNETClassMethods
{
    public class CallNETClass
    {

        // Dice
            public static void CallNETMethod(string[] args) // Dice Method
            {
                // Dice Exapmle
                    Random dice = new();
                    int roll1 = dice.Next();        //Calls a non specified value number
                    int roll2 = dice.Next(101);     //Calls values up to 101
                    int roll3 = dice.Next(50, 101); //Calls values between 50 and 101


                    Console.WriteLine($"First roll: {roll1}");
                    Console.WriteLine($"Second roll: {roll2}");
                    Console.WriteLine($"Third roll: {roll3}");
            }

        // Code challenge: Implement a method of the Math class that returns the larger of two numbers
            public static int Max(int a, int b)  //defines a method to be called expecting 2 integer values
            {
                return (a > b) ? a : b; // Bigger value Method Instructions
            }

            public static void Mathchallenge(string[] args)
            {
                int firstValue = 500;
                int secondValue = 600;

                int largerValue = Max(firstValue, secondValue); // Calls Method

                Console.WriteLine(largerValue); // Print larger value
            }
    }
} 