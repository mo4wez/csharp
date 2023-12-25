namespace Tutorial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = ShowArrayOnOutput(1, 10);
            int ArrayIndex = result.Length;
            for (int i = 0; i < ArrayIndex; i++)
            {
                Console.WriteLine("i[{0}] = {1}", i, i);
            }
        }

        static int[] ShowArrayOnOutput(int start, int end)
        {
            int size = end - start + 1;
            Console.WriteLine("Size: {0}", size);
            int[] MyArray = new int[size];

            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                MyArray[counter] = i;
                counter++;
            }
            return MyArray;
        }
    }
}
