using System;

namespace Задание__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            double y = Math.Atan(Math.Pow(x, 2)) / Math.Abs(x - Math.Sqrt(Math.Sin(x))) + Math.Pow(x, 3);
            Console.WriteLine("y = {0}", y);
            Console.ReadKey();
        }
    }
}
    

