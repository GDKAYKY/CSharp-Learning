using System;

namespace MathOperations
{
    class MathOperationsClass
    {
        public static void MathOperationsMethod(string[] args)
        {
            //Write code to perform addition, subtraction, multiplication, and division with integers
                int sum = 10 + 10;
                int difference = 20 - 5;
                int product = 5 * 5;
                int quotient = 10 / 5;

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Difference: " + difference);
                Console.WriteLine("Product: " + product);
                Console.WriteLine("Quotient: " + quotient);

            // Add code to perform division using literal decimal data
                decimal decimalQuotient = 3.5m / 2  ;
                Console.WriteLine($"Decimal quotient: {decimalQuotient}");

            // Add code to cast results of integer division
                int first = 3;
                int second = 2;
                decimal result = (decimal)first / (decimal)second;
                Console.WriteLine(result);

            // Write code to determine the remainder after integer division
                Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
                Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");   

            // Write code to exercise C#'s order of operations
                int value1 = 5 + 3 * 5;
                int value2 = (3 + 4) * 5;
                Console.WriteLine(value1);
                Console.WriteLine(value2);
        }

    }

}   