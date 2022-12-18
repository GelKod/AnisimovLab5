using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal class Cases
    {
        static void Menu()
        {
            Console.WriteLine("Меню");
            Console.WriteLine("1 - Отгадай ответ");
            Console.WriteLine("2 - Об авторе");
            Console.WriteLine("3 - Try/Catch/Finally");
            Console.WriteLine("4 - Сортировки");
            Console.WriteLine("5 - Крестики - Нолики");
            Console.WriteLine("6 - Строки");
            Console.WriteLine("7 - Выход");
            Console.WriteLine("Выберите пункт");
        }
        public void MetodCases()
        {
            bool clash = false;
            while (!clash)
            {
                int x = 0;
                Menu();
                x = Help.Input();
                Console.WriteLine();
                switch (x)
                {
                    case 1:
                        Case1 c1 = new Case1();
                        c1.Met1();
                        break;
                    case 2:
                        Console.WriteLine("Анисимов Дмитрий Алексеевич \r\n6101-090301D\r\n");
                        break;
                    case 3:
                        Case3 c3 = new Case3();
                        c3.Met3();
                        break;
                    case 4:
                        Case4 c4 = new Case4();
                        c4.Met4();
                        break;
                    case 5:
                        Case5 c5 = new Case5();
                        c5.NoughtsAndCrosses();
                        break;
                    case 6:
                        MenyChar();
                        break;
                    case 7:
                        Case7 c7 = new Case7();
                        clash = c7.Met7();
                        break;
                }
            }
        }
        public void MenyChar()
        {
            Console.WriteLine("1 задание - Посчитать количество гласных и согласных букв в строке (отдельно)");
            Console.WriteLine("2 задание - Посчитать количество букв А(а) в строке.");
            Console.WriteLine("3 задание - Даны три строки. Вывести их на экран по порядку увеличения символов в них (без пробелов).");
            int p;
            int h = Help.Input();
            switch (h)
            {
                case 1:
                    Console.WriteLine("1 - Текст из методички");
                    Console.WriteLine("2 - Текст пользователя");
                    p = Help.Input();
                    switch (p)
                    {
                        case 1:
                            Case6 c6=new Case6();
                            c6.Number1();
                            break;
                        case 2:
                            Case6 c62 = new Case6(Console.ReadLine());
                            c62.Number1();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1 - Текст из методички");
                    Console.WriteLine("2 - Текст пользователя");
                    p = Help.Input();
                    switch (p)
                    {
                        case 1:
                            Case6 c6 = new Case6();
                            c6.Number2();
                            break;
                        case 2:
                            Case6 c62 = new Case6(Console.ReadLine());
                            c62.Number2();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("1 - Текст из методички");
                    Console.WriteLine("2 - Текст пользователя");
                    p = Help.Input();
                    switch (p)
                    {
                        case 1:
                            Case6 c6 = new Case6();
                            c6.Number3();
                            break;
                        case 2:
                            Case6 c62 = new Case6(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                            c62.Number3();
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
