using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal class Case1
    {
        public void Met1()
        {
            bool DivZer = false;
            double a = 0;
            Console.WriteLine("Чему равно значение функции f = Math.Log(b) * Math.Log(b) / (Math.Cos(a) - 1)");
            while (!DivZer)
            {
                a = ReadnumberDouble("Введите a: ");
                if (a != 0)
                {
                    DivZer = true;
                }
                else
                {
                    Console.WriteLine("На ноль делить нельзя!!");
                }
            }
            double b = ReadnumberDouble("Введите b: ");
            double f = Calculation(a, b);
            Puzzle(f);
        }
        public static double ReadnumberDouble(string one)
        {
            double n = 0;
            bool rir = false;
            Console.Write("{0}", one);
            while (!rir)
            {
                rir = double.TryParse(Console.ReadLine(), out n);
                if (!rir)
                {
                    Console.Write("Это не число! Повторите попытку: ");
                    Console.Write("{0}", one);
                }
            }
            return n;
        }
        public static double Calculation(double a, double b)
        {
            double f = Math.Log(b) * Math.Log(b) / (Math.Cos(a) - 1);
            return f;
        }
       
        static int Esli(int u, int perevod, int number)
        {
            if (u == perevod)
            {
                Console.WriteLine("Вы угадали ответ!!! =)");
                number = -1;
            }
            else
            {
                Console.WriteLine("Вы не угадали ответ!!! =(");
                Console.WriteLine("Осталось попыток: " + number);
            }
            return number;
        }
        public static void Puzzle(double f)
        {
            bool znachenie3;
            int u = 0, number = 0, perevod = 0;
            znachenie3 = false;
            for (number = 2; number > -1; number--)
            {
                znachenie3 = false;
                u = Help.Input();
                Console.WriteLine();
                perevod = (int)f;
                number = Esli(u, perevod, number);
            }
            if (number == -1)
            {
                Console.WriteLine("Ваши попытки закончились(");
                Console.WriteLine("Правильный ответ: " + perevod + "\r\n");
            }
        }
    }
}
