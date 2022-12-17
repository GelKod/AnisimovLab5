using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnisimovLab5
{
    internal class Case4
    {
        public void Met4()
        {
            bool cikle = false;
            Console.WriteLine("Введите кол-во элементов массива: ");
            int n = Check();
            int[] arr = Rand(n);
            int[] arr2 = arr;
            Output(arr);
            DateTime dateTime = DateTime.Now;
            arr = Bubble(arr);
            TimeSpan sp = DateTime.Now - dateTime;
            Console.WriteLine("Время сортировки пузырьком: " + sp);
            DateTime dateTime2 = DateTime.Now;
            arr2 = CocktailSort(arr2);
            TimeSpan sp2 = DateTime.Now - dateTime2;
            Console.WriteLine("Время сортировки перемешиванием : " + sp2);
            Output(arr2);
            Console.ReadKey();
        }
        static void Output(int[] d)
        {
            if (d.Length < 100)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    Console.Write(d[i] + ", ");
                }
                Console.WriteLine();
            }
        }
        static int[] Bubble(int[] a)
        {
            int low;
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i + 1] < a[i])
                    {
                        low = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = low;
                    }
                }
            }
            return a;
        }
        static int[] CocktailSort(int[] array)
        {
            int left = 0, i, j, right = array.Length - 1;
            while (left < right)
            {
                for (i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                right--;
                for (i = right; i > left; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                }
                left++;
            }
            return array;
        }
        static int[] Rand(int a)
        {
            int[] arr = new int[a];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 10);
            }
            return arr;
        }
        static int Check()
        {
            bool cikle = false;
            int n = 0;
            while (!cikle)
            {
                cikle = true;
                n = Help.Input();
                if (n < 2)
                {
                    cikle = false;
                }
            }
            return n;
        }
    }
}
