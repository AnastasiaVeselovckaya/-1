using System;

namespace Задание__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.Write("Введите двузначное число 10 - 99:");
                int k = Convert.ToInt32(Console.ReadLine());

                if (k <= 99 && k >= 10)
                {
                    Console.WriteLine("Число единиц в нем = {0}", k % 10);
                }

                else
                {
                    Console.WriteLine(" from 10 - 99 ");
                }
            }
        }
    }
}
