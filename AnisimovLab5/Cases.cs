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
                        Case6 c6 = new Case6();
                        c6.Lines();
                        break;
                    case 7:
                        Case7 c7 = new Case7();
                        clash = c7.Met7();
                        break;
                }
            }
        }
    }
}
