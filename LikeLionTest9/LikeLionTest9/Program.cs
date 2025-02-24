using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int score = 85;
            if(score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else
            {
                Console.WriteLine("B 학점");
            }*/

            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("D 학점");
            }
        }
    }
}
