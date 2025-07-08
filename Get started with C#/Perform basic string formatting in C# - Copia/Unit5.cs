using System;

namespace FormatDisplay
{

    class FormatDisplayClass
    {
        public static void FormatDisplayMethod(string[] parameter)
        {
            // Challenge: Format and display instructions
                string projectName = "ACME";
                string directory = $@"c:\Exercise\";
                string russianMessage = $"\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

                Console.WriteLine("View English output:");
                Console.WriteLine ($@"  {directory}{projectName}\data.txt");
                    Console.WriteLine ("");

                Console.WriteLine($"{russianMessage}:");
                Console.WriteLine($@"  {directory}{projectName}\ru-RU\data.txt");

        }

    }
}