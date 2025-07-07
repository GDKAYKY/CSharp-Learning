using System;

namespace IncrementValues
{
    class IncrementValuesClass
    {
        public static void IncrementValuesMethod(string[] args)
        {
            // Increment and decrement values
                int value = 5;     // value is now 0.
                value = value + 5; // value is now 5.
                value += 10;        // value is now 10.
            // Write code to increment and decrement a value
                int valuealt = 1;

                valuealt = valuealt + 1;
                Console.WriteLine("First increment: " + valuealt);

                valuealt += 1;
                Console.WriteLine("Second increment: " + valuealt);

                valuealt++;
                Console.WriteLine("Third increment: " + valuealt);

                valuealt = valuealt - 1;
                Console.WriteLine("First decrement: " + valuealt);

                valuealt -= 1;
                Console.WriteLine("Second decrement: " + valuealt);

                valuealt--;
                Console.WriteLine("Third decrement: " + valuealt);
        }

    }

}