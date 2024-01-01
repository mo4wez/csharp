namespace OopMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box();
            myBox.setLength(2.4);
            myBox.setWidth(3);
            myBox.setHeight(3);

            double boxVolume = myBox.calcVolume();
            Console.WriteLine("Volume: {0}", boxVolume);

        }
    }

    class Box
    {
        private double length;
        private double width;
        private double height;


        public void setLength(double l)
        {
            length = l;
        }
        public void setWidth(double w)
        {
            width = w;
        }
        public void setHeight(double h)
        {
            height = h;
        }

        public double calcVolume() 
        {
            return length * width * height;
        }
    }
}
