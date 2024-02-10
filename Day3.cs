namespace Practice_Day3
{
    internal class Day3
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            decimal min_dec = decimal.MinValue;
            decimal max_dec = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min_dec} to {max_dec}");


            decimal e = 1.0M;
            decimal f = 3.0M;
            Console.WriteLine(e / f);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }

    }
}

