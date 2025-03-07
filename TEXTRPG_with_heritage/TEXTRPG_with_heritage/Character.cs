using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_with_heritage
{
    public class Character
    {
        public string strName;
        public int iAttack;
        public int iHP;

        public void SetDamage(Character target) { iHP -= target.iAttack; }

        public void Render()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"{strName}");
            Console.WriteLine("체력 : " +iHP +"\t공격력 : "+ iAttack);
        }
    }

    public class Player : Character
    {
        public void SelectJob()
        {
            Console.WriteLine("직업을 선택하세요.(1.기사 2.마법사 3.도둑) : ");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    this.strName = "기사";
                    this.iHP = 100;
                    this.iAttack = 10;
                    break;
                case 2:
                    this.strName = "마법사";
                    this.iHP = 90;
                    this.iAttack = 15;
                    break;
                case 3:
                    this.strName = "도둑";
                    this.iHP = 85;
                    this.iAttack = 13;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }

        }
    }

    public class Monster : Character
    {
        
    }
}
