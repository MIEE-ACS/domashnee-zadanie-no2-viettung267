using System;
namespace Dz_2
{
    class Program
    {
        static double segment1(double x, double a, double b)
        {
            double y = a * x + b;
            if (Math.Round(y, 2) == 0)
                return 0;
            else
                return Math.Round(y, 2);
        }

        static double segment2(double x, double r, double a, double b)
        {
            double y = Math.Sqrt(r * r - (x - a) * (x - a)) - b;
            if (Math.Round(y, 2) == 0)
                return 0;
            else
                return Math.Round(y, 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Radius R = ");
            double r = Convert.ToDouble(Console.ReadLine());

            while (r < 0)
            {
                Console.Write("Enter Radius R again (R > 0) = ");
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
                    Console.WriteLine("y({0}) = {1}", x, segment1(x, 0, -3));
                }

                else if (x == -5)
                {
                    Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, segment1(x, 0, -3), x, segment1(x, 1, 3));
                }

                else if (x <= -3)
                {
                    if (r > 3 && x == -3)
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, segment1(x, 1, 3), x, segment2(x, r, 0, 0));
                    else
                        Console.WriteLine("y({0}) = {1}", x, segment1(x, 1, 3));
                }

                else if (x <= 3)
                {
                    if (r >= 3)
                    {
                        if (x == 3)
                            Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, segment1(x, 1, 3), x, segment2(x, r, 0, 0));
                        else
                            Console.WriteLine("y({0}) = {1}", x, segment2(x, r, 0, 0));
                    }
                    else if (x >= -r && x <= r)
                        Console.WriteLine("y({0}) = {1}", x, segment2(x, r, 0, 0));
                    else
                        Console.WriteLine("Function not defined");
                }

                else if (x <= 8)
                {
                    Console.WriteLine("y({0}) = {1}", x, segment1(x, 0.6, -1.8));
                }

                else if (x <= 10)
                {
                    Console.WriteLine("y({0}) = {1}", x, segment1(x, 0, 3));
                }
            }
        }
    }
}