namespace DesicionLogic
{
    public class DesicionLogicClass
    {
        public static void DecisionLogicMethod(string[] args)
        {
            Random dicealt = new();

            int roll1 = dicealt.Next(1, 7);
            int roll2 = dicealt.Next(1, 7);    
            int roll3 = dicealt.Next(1, 7);
            bool result = true;

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if (total > 14)
            {
                result = false;
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                result = true;
                Console.WriteLine("Sorry, you lose.");
            }

            if (result == false)
            {
                Console.WriteLine("Saldo 100R$");
            }
        }
    }
}