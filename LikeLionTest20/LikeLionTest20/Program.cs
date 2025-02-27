using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest20
{
    class Program
    {
        //열거형이란?
        //Enumeration enum
        //숫자 값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미 있는 값으로 표현 가능
        //기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가

        //기본적인 enum 사용법
        enum DayOfWeek
        {
            Sunday,
            Monday,
            TuesDay,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        enum WeaponType
        { Sword, Bow, Staff}

        static void ChooseWeapon(WeaponType weapon)
        {
            if (weapon == WeaponType.Sword)
            {
                Console.WriteLine($"{weapon}을 선택했습니다.");
            }
            else if (weapon == WeaponType.Bow)
            {
                Console.WriteLine($"{weapon}을 선택했습니다.");
            }
            else if (weapon == WeaponType.Staff)
            {
                Console.WriteLine($"{weapon}을 선택했습니다.");
            }

        }
        static void Main(string[] args)
        {
            /*DayOfWeek today = DayOfWeek.Wednesday;

            //숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
            Console.WriteLine(today);
            Console.WriteLine((int)today);

            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);
            Console.WriteLine((int)status);*/

            ChooseWeapon(WeaponType.Staff);
        }
    }
}
