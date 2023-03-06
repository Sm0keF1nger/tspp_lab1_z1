using System;

namespace lab1_z1
{
    public class Program
    {
        static public int Equation(int x)
        {
            double y;
            y = Math.Pow(x, 3) - 4 * Math.Pow(x, 2) - 5 * x + 9 + Math.Cos(x);
            Console.WriteLine("y = x^3 - 4x^2 - 5x + 9 + cos(x)");
            Console.WriteLine("x = " + x.ToString());
            Console.WriteLine("y = " + y.ToString());
            return (int)y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число");
            string inser = Console.ReadLine();
            int x = int.Parse(inser);
            Equation(x);
            Console.ReadLine();
        }
    }
}
