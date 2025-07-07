using System;

namespace DisplayLiteralandVariables
{
    class DisplayLiteralandVariablesClass
    {
        public static void DisplayLiteralandVariablesMethod(string[] args)
        {
            string userName = "Bob";
            int messageCount = 3;
            double temperature = 34.4;

            Console.Write("Hello, ");
            Console.Write(userName);
            Console.Write("! You have ");
            Console.Write(messageCount);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");
        }
    }
}