namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box();
            Box.Material = "Iron";
            myBox.length = 3.25;
            myBox.breadth = 4.3;
            myBox.height = 8.0;
            myBox.color = "Brown";

            Console.WriteLine("length: {0}", myBox.length);
            Console.WriteLine("breadth: {0}", myBox.breadth);
            Console.WriteLine("heigth: {0}", myBox.height);
            Console.WriteLine("color: {0}", myBox.color);
            Console.WriteLine("Box Material: {0}", Box.Material);
        }
    }

    class Box
    {
        public double length;
        public double breadth;
        public double height;
        public string color;
        public static string Material;
    }
}
