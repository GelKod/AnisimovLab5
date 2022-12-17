using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal class Case3
    {
        public void Met3()
        {
            Console.WriteLine("Введите a");
            int a = Help.Input();
            Console.WriteLine("Введите b");
            int b = Help.Input();
            try
            {
                int c = a / b;
                Console.WriteLine("Число делится");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя!!");
            }
        }
    }
}
