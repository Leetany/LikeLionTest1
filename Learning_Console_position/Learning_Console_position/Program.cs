using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning_Console_position
{
    class Program
    {
        static void Main(string[] args)
        {
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            //콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false; //커서 숨기기

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                             대장장이키우기                                  ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);

            for (int x = 0; x < 30; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("◎");
                Thread.Sleep(100);
            }
        }
    }
}
