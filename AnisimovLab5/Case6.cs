using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal class Case6
    {
        public void Lines()
        {
            Console.WriteLine("1 задание - Посчитать количество гласных и согласных букв в строке (отдельно)");
            Console.WriteLine("2 задание - Посчитать количество букв А(а) в строке.");
            Console.WriteLine("3 задание - Даны три строки. Вывести их на экран по порядку увеличения символов в них (без пробелов).");
            int h, p;
            string stringOneNumber = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\nИ хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\nОн так свирлеп и дик,\r\nА в глуще рымит исполин -Злопастный Брандашмыг.";
            string stringTwoNumber1 = "Как уже ветерок весенний";
            string stringTwoNumber2 = "Поселился в зеленом ростке.";
            string stringTwoNumber3 = "Не успела отнять руки,";
            h = Help.Input();
            switch (h)
            {
                case 1:
                    Console.WriteLine("1 - Текст из методички");
                    Console.WriteLine("2 - Текст пользователя");
                    Console.WriteLine(stringOneNumber);
                    p = Help.Input();
                    switch (p)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1 - Текст из методички");
                    Console.WriteLine("2 - Текст пользователя");
                    Console.WriteLine(stringOneNumber);
                    p = Help.Input();
                    switch (p)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("1 - Текст из методички");
                    Console.WriteLine("2 - Текст пользователя");
                    Console.WriteLine(stringTwoNumber1);
                    Console.WriteLine(stringTwoNumber2);
                    Console.WriteLine(stringTwoNumber3);
                    p = Help.Input();
                    switch (p)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
