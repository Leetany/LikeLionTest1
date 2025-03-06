using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG2
{
    public class Field
    {
        Player m_Player = null;
        //몬스터 
        Monster m_Monster = null;

        //플레이어 maingame에서 생성한거 가지고 오면 됨
        //플레이어가 필드에서 전투를 하면 데미지를 입을 거고 hp 깍임
        //ref 적용
        public void SetPlayer(ref Player player) { m_Player = player; }

        public void Progress()
        {
            //사냥터로 들어옴
            int iInput = 0;
            while(true)
            {
                Console.Clear();

                m_Player.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) break;

                if(iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }

        public void Create(string strName, int iHP, int iAttack, out Monster monster)
        {
            monster = new Monster();
            INFO tMonster = new INFO();

            tMonster.iName = strName;
            tMonster.iHP = iHP;
            tMonster.iAttack = iAttack;

            monster.SetMonster(tMonster);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out m_Monster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_Monster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out m_Monster);
                    break;
            }
        }

        public void Fight()
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear();
                m_Player.Render();
                m_Monster.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    m_Player.SetDamage(m_Monster.GetMonster().iAttack);
                    m_Monster.SetDamage(m_Player.GetInfo().iAttack);

                    if(m_Player.GetInfo().iHP <=0)
                    {
                        m_Player.SetHP(100);
                        break;
                    }
                }

                if(iInput == 2 || m_Monster.GetMonster().iHP <=0)
                {
                    m_Player.SetHP(100);
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("====================");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
