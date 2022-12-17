using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal class Case7
    {
        public bool Met7()
        {
            bool clash = false;
            bool rar = false;
            while (!rar)
            {
                Console.WriteLine("Хотите выйти из программы?\r\nд-да\r\nн-нет");
                string choice = Console.ReadLine();
                if (choice == "д")
                {
                    rar = true;
                    clash = true;
                }
                else if (choice == "н")
                {
                    rar = true;
                }
            }
            return clash;
        }
    }
}