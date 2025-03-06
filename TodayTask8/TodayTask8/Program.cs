using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask8
{
    class Program
    {
        class Warrior
        {
            public string Name { get; set; }
            public int Score { get; set; }
            public int Strength { get; set; }
        }
        static void Main(string[] args)
        {
            //Warrior warrior = new Warrior { Name = "김전사", Score = 80, Strength = 100 };

            //Console.WriteLine($"Name : {warrior.Name}, Score : {warrior.Score}, Strength : {warrior.Strength}");

            /*try
            {
                int p = 0;
                Console.Write($"정수를 입력하세요 : ");
                p = int.Parse(Console.ReadLine());
                Console.WriteLine($"입력된 숫자 : {p}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"올바른 숫자를 입력하세요!");
            }*/

            /*List<string> list = new List<string>();
            list.Add("사과");
            list.Add("바나나");
            list.Add("포도");
            foreach(var a in list)
            {
                Console.WriteLine(a);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("첫 번째 작업");
            queue.Enqueue("두 번째 작업");
            queue.Enqueue("세 번째 작업");
            foreach (var a in queue)
            {
                Console.WriteLine(a);
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            while(stack.Count >0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*Console.WriteLine("Hello, C# World!를 입력하시오.");
            
            StringBuilder sb = new StringBuilder();
            sb.Append(Console.ReadLine());
            Console.WriteLine(sb.ToString().ToUpper());
            Console.WriteLine(sb.Replace("C#", "CSharp"));
            Console.WriteLine(sb.Length);*/

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach(var num in evenNumbers)
            {
                sum += num;
            }
            Console.WriteLine($"총합 : {sum}");
        }
    }
}
