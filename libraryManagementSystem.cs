using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{

    // Система управления библиотекой.
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books = { {"Пушкин", "Лермонтов", "Глуховский"}, 
                {"Стивен Кинг", "Говард Лавкрафт", "Брэм Строкер"}, 
                {"Данцова", "Ален Карр", "Игорь Прокопенко"} };

            while(isOpen)
            {
                Console.WriteLine("Библиотека.");
                Console.WriteLine("1 - узнать, что за книга, зная её индекс.");
                Console.WriteLine("2 - найти книгу по автору.");
                Console.WriteLine("3 - вывести все книги.");
                Console.WriteLine("4 - выход.");
                Console.Write("Введите пункт меню => ");

                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int rows;
                        int cols;
                        Console.Write("Введите номер полки: ");
                        rows = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер ряда: ");
                        cols = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("\nЭто книга - " + books[rows, cols]);
                        break;
                    case 2:
                        string author;
                        bool authorIsFind = false;
                        Console.Write("Введите нужного автора: ");
                        author = Console.ReadLine();

                        for(int i = 0; i < books.GetLength(0); i++)
                        {
                            for(int p = 0; p < books.GetLength(1); p++)
                            {
                                if(author.ToLower() == books[i, p].ToLower())
                                {
                                    Console.WriteLine("Автор - " + books[i, p] + 
                                        " находится по адресу - " + (i + 1) + " | " + (p + 1));
                                    authorIsFind = true;
                                }
                            }
                        }
                        if(authorIsFind == false)
                        {
                            Console.WriteLine("Увы. Такого автора нет.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nВесь список авторов:\n");
                        for(int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i, j]);
                            }
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
