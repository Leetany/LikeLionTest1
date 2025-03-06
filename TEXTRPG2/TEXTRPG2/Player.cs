using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG2
{
    public class Player
    {
        public INFO m_Info;

        //공격할 때 라고 생각했는데 데미지 입는 것만 만들어 주면 되는구만..
        public void SetDamage(int iAttack) { m_Info.iHP -= iAttack; }
        //플레이어 정보를 외부에서 볼 수 있게 반환 해줘야 함
        public INFO GetInfo() { return m_Info; }
        //hp를 다시 설정해주는 함수
        public void SetHP(int HP) { m_Info.iHP = HP; }

        //직업 선택
        public void SelectJob()
        {
            m_Info = new INFO();

            Console.WriteLine("직업을 선택하세요.(1.기사 2.마법사 3.도적) : ");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());
            CreateJob(iInput);
        }

        public void CreateJob(int input)
        {
            switch(input)
            {
                case 1:
                    m_Info.iName = "기사";
                    m_Info.iHP = 100;
                    m_Info.iAttack = 10;
                    break;
                case 2:
                    m_Info.iName = "마법사";
                    m_Info.iHP = 90;
                    m_Info.iAttack = 15;
                    break;
                case 3:
                    m_Info.iName = "도적";
                    m_Info.iHP = 85;
                    m_Info.iAttack = 17;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("직업 이름 : " + m_Info.iName);
            Console.WriteLine("체력 : " + m_Info.iHP + "\t공격력 : " + m_Info.iAttack);
        }

        public Player() { }
        ~Player() { }
    }
}
