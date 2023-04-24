namespace area_using_delegates_17_04_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle(delegate(double l, double b, string yellow)
            {
                double calculate = l * b;
                Console.WriteLine($"area of rectangle is {calculate} and the color is {yellow}");
            });

            triangle t = new triangle(delegate (double l, double b, string blue)
            {
                double calculate = l * b * .5;
                Console.WriteLine($"area of triangle is {calculate} and the color is {blue}");
                
            });

            square s = new square(delegate (double l, double b, string red)
            {
                double calculate = l * b ;
                
                Console.WriteLine($"area of square is {calculate} and the color is {red}");
            });

            double l = 12, b = 3;
            r(l, b, "yellow");
            t(l, b, "black");
            s(l, b, "pink");

            Console.ReadKey();
        }
    }
}