using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"number: {i}");
            }*/

            /*for (int i =0; i<=9;i++)
            {
                Console.WriteLine($"number: {i}");
            }*/

            /*int sum = 0;
            for (int i = 1; i<=10; i++)
            {
                sum += i;                
            }
            Console.WriteLine(sum);*/

            int count = 1;

            while (count <= 5)
            {
                Console.WriteLine($"Count: " + count);
                count++;

                if (count == 3)
                {
                    Console.WriteLine($"exit when 3");
                    break;
                }

            }
            Console.WriteLine($"Count: " + count);
        }
    }
}
