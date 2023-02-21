using System;
using System.Collections.Generic;

namespace Pozdravlalka
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Fio = 
                { "Tom", "Bob", "Sam"};
            Int32[] Age = 
                {19, 22, 50};
            String[] Data = 
                {"22.02", "27.01", "10.04"};


            Console.WriteLine("Введите 'spisok' для выведения спсика Дней рождения " +
                "Введите 'red' для редактирования");
            string q = Console.ReadLine();

            Console.WriteLine("Введите Ден.Месяц");
            string w = Console.ReadLine();


            for (int i = 0; i <= 100; i++)
            {
                if (q == "spisok")
                {
                    for (int f = 0; f <= 10; f++)
                    {
                        if (w == Data[f])
                        {
                            Console.WriteLine("Номер в списке: " + f + "ФИО: " + Fio[f] + ", Возраст: " + Age[f]);
                        }
                    }

                }
                else if (q == "red")
                {
                    for (int f = 0; f <= 10; f++)
                    {
                     Console.WriteLine("Номер в списке: " + f + "ФИО: " + Fio[f] + ", Возраст: " + Age[f] + ", Дата дня рождения: " + Data[f]);
                    }

                    Console.WriteLine("Введите номер в списке");
                    int y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите новое имя, возраст, Ден.Месяц");
                    Fio[y] = Console.ReadLine();
                    Age[y] = int.Parse(Console.ReadLine());
                    Data[y] = Console.ReadLine();

                    for (int f = 0; f <= 10; f++)
                    {
                        Console.WriteLine("Номер в списке: " + f + "ФИО: " + Fio[f] + ", Возраст: " + Age[f] + ", Дата дня рождения: " + Data[f]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
