using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal static class Help
    {
        public static int Input()
        {
            int input = 0;
            bool clans = false;
            while (!clans)
            {
                Console.Write("Ввод: ");
                clans = int.TryParse(Console.ReadLine(), out input);
                if (!clans)
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
            return input;
        }
    }
}
