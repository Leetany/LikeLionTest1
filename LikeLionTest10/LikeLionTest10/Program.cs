using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                default:
                    Console.WriteLine("유효하지 않은 요일");
                    break;
            }*/

            Console.WriteLine("Choose your class (1. sword 2. magician 3. assassin");
            int Class = int.Parse(Console.ReadLine());

            switch(Class)
            {
                case 1:
                    Console.WriteLine("swrod");
                    Console.WriteLine("Att: 100");
                    Console.WriteLine("Def: 90");
                    break;
                case 2:
                    Console.WriteLine("magician");
                    Console.WriteLine("Att: 110");
                    Console.WriteLine("Def: 80");
                    break;
                case 3:
                    Console.WriteLine("assassin");
                    Console.WriteLine("Att: 115");
                    Console.WriteLine("Def: 70");
                    break;
            }
        }
    }
}
