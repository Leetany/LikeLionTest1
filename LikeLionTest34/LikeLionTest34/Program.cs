using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LikeLionTest34
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);

            //int identity(int n)
            //{
            //  return n;
            //}

            foreach(var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            var firstName = names.First(n => n.StartsWith("A"));
            Console.WriteLine($"First name starting with A : {firstName}");*/

            //메서드 구문, 쿼리 구문
            /*int[] nums = { 5, 3, 8, 1 };

            //메서드 구문
            var sortedMethod = nums.OrderByDescending(n => n);

            //쿼리 구문
            var sortedQuery = from n in nums
                              orderby n
                              select n;

            Console.WriteLine("Meshod syntax");
            foreach (var n in sortedMethod) Console.WriteLine(n);

            Console.WriteLine("Query syntax");
            foreach (var n in sortedQuery) Console.WriteLine(n);*/

            //Select()로 길이 추출

            /*string[] words = { "apple", "banana", "cherry" };

            var lengths = words.Select(w => w.Length);

            foreach(var length in lengths)
            {
                Console.WriteLine(length);
            }

            //select 개념
            //Linq 쿼리 연산자 중 하나
            //각 요소를 변환하여 새로운 컬렉션을 생성

            var upperWords = words.Select(w => w.ToUpper());
            foreach(var word in upperWords)
            {
                Console.WriteLine(word);
            }*/

            /*int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (var d in data)
                sum += d;

            Console.WriteLine($"Sum : {sum}");*/

            /*int[] data = { 1, 2, 3, 4, 5 };

            int count = data.Length; //개수

            Console.WriteLine($"Count : {count}");*/

            /*float[] data = { 80, 76, 65 };
            double avg = data.Average();

            Console.WriteLine($"Average : {avg:F2}");*/

            /*int[] data = { 55, 76, 65 };
            int max = data.Max();
            int min = data.Min();

            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Min : {min}");*/

            /*int[] data = { 10, 12, 20, 25, 30 };
            int target = 22;
            int nearest = data[0];

            foreach(var d in data)
            {
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                    nearest = d;
            }

            Console.WriteLine($"Nearest to {target}: {nearest}");*/

            /*int[] scores = { 90, 70, 50, 70, 60 };

            for(int i =0;i<scores.Length; i++)
            {
                int rank = 1;

                for(int j=0; j<scores.Length;j++)
                {
                    if (scores[j] > scores[i])
                        rank++;
                }
                Console.WriteLine($"Score : {scores[i]}, Rank : {rank}");
            }    */

            /*int[] data = { 5, 2, 8, 1, 9 };
            Array.Sort(data);

            foreach(var d in data)
            {
                Console.WriteLine(d);
            }*/

            /*int[] data = { 5, 2, 8, 1, 9 };
            int target = 8;
            int index = -1;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index >= 0 ? $"Found at index{index}" : "Not Found");*/

            //그룹화하기: GROUP 알고리즘
            //데이터를 특정 기준으로 그룹화하기

            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

            var groups = fruits.GroupBy(f => f[0]);  //첫 글자로 그룹화

            foreach (var group in groups)
            {
                Console.WriteLine($"Key : {group.Key}");

                foreach(var item in group)
                {
                    Console.WriteLine($"{item}");
                }
            }


        }
    }
}
