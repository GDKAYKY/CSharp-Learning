using System; 

namespace Unit3
    {
        class Unit3Class
        {
            // Combine strings using string concatenation
                public static void Unit3Method(string[] args)
                {
                string day = "20";
                string month = "03";
                string date = month + "/" + day; //american format

                    Console.Write("The date is: ");
                    Console.WriteLine(date + " " + "\n" + "the day is " + day + "!");
                }
        }
    }