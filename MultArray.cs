using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    class Program
    {
        static void Main(string[] args)
        {
            // ~~ МНОГОМЕРНЫЙ МАССИВ ~~
            // Объявления двухмерного массива
            // 1) тип[,] имя_массива = {{}, {}, {}};
            // 2) тип[,] имя_массива = new тип[размер] {{}, {}, {}};

            // Не можем указать разное кол-во элементов.
            // Везде должно быть одно и то же кол-во элементов.
            int[,] array = new int[5, 5];
            Random rand = new Random();

            // GetLength - Получаем размер определенного измерения.
            for(int i = 0; i < array.GetLength(0); i++) // Перебирает только строки.
            {
                for(int j = 0; j < array.GetLength(1); j++) // Перебирает элементы.
                {
                    // Полочка - i; Столбец - j;
                    array[i, j] = rand.Next(0, 9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            Console.ReadLine();
        }
    }
}
