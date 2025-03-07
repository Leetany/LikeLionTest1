using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_FOR_TEST
{
    public class INFO
    {
        public string strName;
        public int iHP;
        public int iAttack;

        public void SetDamage(INFO target) { iHP -= target.iAttack; }

        public void Render()
        {
            Console.WriteLine("==================================");
            Console.WriteLine(strName);
            Console.WriteLine("체력 : " + iHP + "\t공격력 : " + iAttack);
        }
    }

    public class Player : INFO
    {
        public void SelectJob()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("직업을 선택하세요.(1.기사 2.마법사 3.도둑)");
            int iInput = int.Parse(Console.ReadLine());

            switch(iInput)
            {
                case 1:
                    strName = "기사";
                    iHP = 100;
                    iAttack = 10;
                    break;
                case 2:
                    strName = "마법사";
                    iHP = 90;
                    iAttack = 15;
                    break;
                case 3:
                    strName = "도둑";
                    iHP = 85;
                    iAttack = 17;
                    break;
                default:
                    Console.WriteLine("보기 중에서 골라주세요.");
                    SelectJob();
                    break;
            }
        }
    }

    public class Monster : INFO
    {

    }
}
