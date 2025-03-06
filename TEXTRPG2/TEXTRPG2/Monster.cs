using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG2
{
    public class Monster
    {
        public INFO m_Monster; //몬스터 데이터

        //이놈도 피 깍여야 됨 깍여서 죽는거 구현해야 돼
        public void SetDamage(int iAttack) { m_Monster.iHP -= iAttack; }

        //INFO 클래스 타입 인자로 몬스터 데이터를 넣어준다.
        public void SetMonster(INFO monster) { m_Monster = monster; }
        public INFO GetMonster() { return m_Monster; }

        public void Render()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("몬스터 이름 : " + m_Monster.iName);
            Console.WriteLine("체력 : " + m_Monster.iHP + "\t공격력" + m_Monster.iAttack);
        }

        public Monster() { }
        ~Monster() { }
    }
}
