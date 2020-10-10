using System;
namespace Dz_2
{
    class Program
    {
        static double segment1(double x, double a, double b)
        {
            double y = a * x + b;
            return y;
        }
        static double segment2(double x, double r, double a, double b)
        {
            double y = Math.Sqrt(r * r - (x - a) * (x - a)) - b;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Radius R (0 -> 3) = ");
            double r = Convert.ToDouble(Console.ReadLine());
            while (r > 3 || r < 0)
            {
                Console.Write("Enter Radius R again (0 -> 3) = ");
                r = Convert.ToDouble(Console.ReadLine());
            }
            for (double x = -8; x <= 10; x += 0.2)
            {
                x = Math.Round(x, 2);
                if (x < -8 || x > 10)
                {
                    Console.WriteLine("Function not defined");
                }
                else if (x < -5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, 0, -3));
                }
                else if (x == -5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00} or y({2:0.00}) = {3:0.00} ", x, segment1(x, 0, -3), x, segment1(x, 1, 3));
                }
                else if (x <= -3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, 1, 3));
                }
                else if (x < -r)
                {
                    Console.WriteLine("Function not defined");
                }
                else if (x <= r)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x, r, 0, 0));
                }
                else if (x < 3)
                {
                    Console.WriteLine("Function not defined");
                }
                else if (x <= 8)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, 0.6, -1.8));
                }
                else if (x <= 10)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, 0, 3));
                }
            }
        }
    }
}