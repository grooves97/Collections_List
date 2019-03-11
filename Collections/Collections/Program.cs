using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;
            int i = 0;
            while (i < list.Capacity)
            {
                if (i % 2 == 0) sum += list[i];
                ++i;
            }
            Console.WriteLine($"Summ of elements with = {sum}");

            list.RemoveAt(list.IndexOf(list.Max()));

            Console.WriteLine($"Second maximum = {list.Max()}");
            Console.ReadLine();
        }
    }
}
