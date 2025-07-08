using System;

namespace StringInterpolation
{
    class StringInterpolationClass
    {
        public static void StringInterpolationMethod(string[] args)
        {
            // What is string interpolation?
                string hello = "Good Morning";
                string name = "Bob";
                string greetings = $"{hello} {name}";

                Console.WriteLine(greetings);

            // Use string interpolation to combine a literal string and a variable value

                string message = $"{hello} {name}, you have one unread message.\n";

                Console.WriteLine(message);

            // Use string interpolation with multiple variables and literal strings

                int testresult = 4;
                string warning = $"You have Scored {testresult}/10";
                string mytestresult = $"{warning}, you are under risk of failing the class!!!";

                Console.WriteLine(mytestresult);

            // Avoid intermediate variables

                Console.WriteLine ($"{warning}, you are under risk of failing the class!!!\n");

            // Combine verbatim literals and string interpolation

                string projectname = "LearningRust";

                Console.WriteLine($@"C:\repos\{projectname}\Unit1.rs");   
        }
    }
}