namespace area_using_delegates_17_04_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle(delegate(double l, double b)
            {
                Console.WriteLine(l * b );
            });

            triangle t = new triangle(delegate (double l, double b)
            {
                Console.WriteLine(l * b * .5);
            });
            double l = 12, b = 3;
            r(l, b);
            t(l, b);
        }
    }
}