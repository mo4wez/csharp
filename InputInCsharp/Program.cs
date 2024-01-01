namespace InputInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start: ");
            string start = Console.ReadLine();
            Console.Write("Enter end: ");
            string end = Console.ReadLine();

            int[] arrayResult = OneToTenCounterWithInput(Convert.ToInt32(start), Convert.ToInt32(end));

            for (int i = 0; i < arrayResult.Count(); i++) {
                Console.WriteLine(arrayResult[i]);
            }
        }

        static int[] OneToTenCounterWithInput(int start, int end) {
            int arraySize = end - start + 1;
            int[] myArray = new int[arraySize];
            int counter = 0;
            for (int i = start; i <= end; i++) {
                myArray[counter] = i;
                counter++;
            }
            return myArray;
        }
    }
}
