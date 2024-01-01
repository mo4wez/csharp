namespace ListAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 70;
            myArray[3] = 80;

            for (int i = 0; i < myArray.Count(); i++)
            {
                Console.WriteLine("myArray"+"["+i+"]"+" = "+ myArray[i]);
            }
            Console.Write("Enter number: ");
            string arrayIndex = Console.ReadLine();

            Console.WriteLine("Index of {0}: {1}", arrayIndex, Array.IndexOf(myArray, Convert.ToInt32(arrayIndex)));
            Console.WriteLine("Min number in array: {0}", myArray.Min());
            Console.WriteLine("Max number in array: {0}", myArray.Max());

            // ==============
            List<int> myList = new List<int>();
            myList.Add(4);
            myList.Add(7);
            myList.Add(12);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("myList" + "[" + i + "]" + " = " + myList[i]);
            }
            Console.Write("Enter number: ");
            string listIndex = Console.ReadLine();

            Console.WriteLine("Index of {0}: {1}", listIndex, myList.IndexOf(Convert.ToInt32(listIndex)));
            Console.WriteLine("Min number in List: {0}", myList.Min());
            Console.WriteLine("Max number in List: {0}", myList.Max());

        }
    }
}
