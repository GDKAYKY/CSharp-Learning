using Unit2;
using Unit4;
using Unit3;
using StringInterpolation;
using FormatDisplay;
using PrintLiteralValues;
using SetupVariables;
using DisplayLiteralandVariables;

namespace Program
{
    class Program
    {
        static void Main(string[] args)

        // Get started with C#
            
            {
                //Write your first C# code
                    Unit2Class.Unit2Method(args);

                        Console.WriteLine("\n");

                    Unit4Class.Unit4Method(args);

                        Console.WriteLine("\n");

                    Unit3Class.Unit3Method(args);

                        Console.WriteLine("\n");

                //Store and retrieve data using literal and variable values in C#

                    PrintLiteralValuesClass.PrintLiteralValuesMethod(args);

                        Console.WriteLine("\n");

                    SetupVariablesClass.SetupVariablesMethod(args);

                        Console.WriteLine("\n");
                    
                    DisplayLiteralandVariablesClass.DisplayLiteralandVariablesMethod(args);

                        Console.WriteLine("\n");
                        
                //Perform basic string formatting in C#

                    StringInterpolationClass.StringInterpolationMethod(args);

                        Console.WriteLine("\n");

                    FormatDisplayClass.FormatDisplayMethod(args);

                        Console.WriteLine("\n");    
            }

    }
}