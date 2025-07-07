using System;

namespace ImplicitDataConversion
{
    class ImplicitDataConversionClass
    {
        public static void ImplicitDataConversionMethod(string[] args)
        {
            // Add two numeric values
                int firstNumber = 10;
                int secondNumber = 10;
                Console.Write("Sum Result: ");
                Console.WriteLine(firstNumber + secondNumber);
            
            // Mix data types to force implicit type conversions
                string firstName = "Kayky";
                int widgetsSold = 100;
                Console.WriteLine(firstName + " sold " + widgetsSold + " tickets.");

            // Attempt a more advanced case of adding numbers and concatenating strings 
                Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " tickets.");
        }

    }

}