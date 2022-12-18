using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal class Case6
    {

        const string lat = "уеэоаыяиюё";
        const string lat2 = "aeiouy";
        const string lat3 = "бвгджзйклмнпрстфхцчшщ";
        const string lat4 = "bcdfghjklmnpqrstvwxyz";
        const string num1 = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\nИ хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\nОн так свирлеп и дик,\r\nА в глуще рымит исполин -Злопастный Брандашмыг.";
        const string num2 = "Как уже ветерок весенний";
        const string num3 = "Поселился в зеленом ростке.";
        const string num4 = "Не успела отнять руки,";

        string stringOneNumber, stringTwoNumber1, stringTwoNumber2, stringTwoNumber3;
        public Case6()
        {
            stringOneNumber = num1;
            stringTwoNumber1 = num2;
            stringTwoNumber2 = num3;
            stringTwoNumber3 = num4;
        }
        public Case6(string str)
        {
            stringOneNumber = str;
        }
        public Case6(string str, string str2, string str3)
        {
            stringTwoNumber1 = str;
            stringTwoNumber2 = str2;
            stringTwoNumber3 = str3;
        }
        public void Answer(string kol, string join, string loh)
        {
            Console.WriteLine("1 - " + kol);
            Console.WriteLine("2 - " + join);
            Console.WriteLine("3 - " + loh);
        }
        public int KolVoElementov(string[] mas)
        {
            int kolVo = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                kolVo = kolVo + mas[i].Length;
            }
            return kolVo;
        }
        public void Number1()
        {
            string stringOneNumberLower = stringOneNumber.ToLower();
            int kolVo = 0, kolVo1 = 0;
            for (int i = 0; i < stringOneNumber.Length; i++)
            {
                for (int j = 0; j < lat.Length; j++)
                {
                    if (stringOneNumberLower[i] == lat[j])
                    {
                        kolVo++;
                    }
                }
                for (int j = 0; j < lat2.Length; j++)
                {
                    if (stringOneNumberLower[i] == lat2[j])
                    {
                        kolVo++;
                    }
                }
                for (int j = 0; j < lat3.Length; j++)
                {
                    if (stringOneNumberLower[i] == lat3[j])
                    {
                        kolVo1++;
                    }
                }
                for (int j = 0; j < lat4.Length; j++)
                {
                    if (stringOneNumberLower[i] == lat4[j])
                    {
                        kolVo1++;
                    }
                }
            }
            Console.WriteLine(kolVo);
            Console.WriteLine(kolVo1);
        }
        public void Number2()
        {
            string stringOneNumberLower = stringOneNumber.ToLower();
            int kolVo = 0;
            for (int i = 0; i < stringOneNumber.Length; i++)
            {
                if (stringOneNumberLower[i] == lat[4] || stringOneNumberLower[i] == lat2[0])
                {
                    kolVo++;
                }
            }
            Console.WriteLine(kolVo);
        }
        public void Number3()
        {
            string[] stringTwoNumber1Split = stringTwoNumber1.Split();
            string[] stringTwoNumber2Split = stringTwoNumber2.Split();
            string[] stringTwoNumber3Split = stringTwoNumber3.Split();
            int chill = KolVoElementov(stringTwoNumber3Split);
            int chill1 = KolVoElementov(stringTwoNumber2Split);
            int chel = KolVoElementov(stringTwoNumber1Split);
            Finnder(chill, chill1, chel);
        }
        public void Finnder(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Answer(stringTwoNumber1, stringTwoNumber2, stringTwoNumber3);
                    }
                    else
                    {
                        Answer(stringTwoNumber1, stringTwoNumber3, stringTwoNumber2);
                    }
                }
                else
                {
                    Answer(stringTwoNumber3, stringTwoNumber1, stringTwoNumber2);
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Answer(stringTwoNumber2, stringTwoNumber1, stringTwoNumber3);
                    }
                    else
                    {
                        Answer(stringTwoNumber2, stringTwoNumber3, stringTwoNumber1);
                    }
                }
                else
                {
                    Answer(stringTwoNumber3, stringTwoNumber2, stringTwoNumber1);
                }
            }

        }
    }
}
