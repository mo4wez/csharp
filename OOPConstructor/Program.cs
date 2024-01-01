namespace OOPConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box(0, 2, 0);
            Console.WriteLine("Box Volume: {0}", myBox.CalcVolume());
        }
    }

    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            if (length > 1)
            {
                this.length = length;
            }
            else 
            {
                this.length = 1;
                Console.WriteLine("Length changed to 1");
            }
            if (width > 1)
            {
                this.width = width;
            }
            else
            {
                this.width = 1;
                Console.WriteLine("Width changed to 1");
            }
            if (height > 1)
            {
                this.height = height;
            }
            else
            {
                this.height = 1;
                Console.WriteLine("Height changed to 1");
            }
        }

        public double CalcVolume()
        {
            return length * width * height;
        }
    }
}
