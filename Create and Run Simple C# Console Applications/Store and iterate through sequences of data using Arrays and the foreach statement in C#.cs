namespace ArrayForeachDataSequences
{
    public class ArrayForeachDataSequencesClass
    {
        public static void ArrayBasics(string[] args)
        {
            string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
                Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
                Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            foreach (string id in fraudulentOrderIDs)
            {
                Console.WriteLine(id);
            }
        }
    }
}