using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            double att = 56.7;
            string charactername = "Alice";
            char rank = 'S';

            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"ATTACK: {att}");
            Console.WriteLine($"Name: {charactername}");
            Console.WriteLine($"Rank: {rank}");
        }
    }
}
