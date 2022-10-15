using System;

namespace Задание__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите периметр равностороннего треугольника: "); // вывод сообщения
            double perimetr = Convert.ToInt32(Console.ReadLine()); // получение значения периметра с консоли в переменную с плавающей точкой 
            double S = Math.Pow(perimetr / 3, 3.0); // возводим в 3 степень значение стороны(периметр делённый на 3)
            Console.WriteLine("Площадь равна: " + S); // вывод в консоль
            Console.Read(); // чтение консоль, иначе она выполнит решение и быстро закроется
        }
    }
}
