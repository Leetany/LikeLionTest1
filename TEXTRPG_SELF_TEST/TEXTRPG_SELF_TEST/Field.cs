using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_SELF_TEST
{
    
    public class Field
    {
        Player m_Player = null;
        Monster m_Monster = null;

        public void SetPlayer(Player player) { m_Player = player; }
        public void Progress()
        {
            int iInput = 0;
            DrawMap();

            while(true)
            {
                Console.Clear();
                m_Player.Render();
                DrawMap();
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) break;

                if(iInput <=3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }


        }
        public void DrawMap()
        {
            Console.WriteLine("1.초보맵");
            Console.WriteLine("2.중수맵");
            Console.WriteLine("3.고수맵");
            Console.WriteLine("4.전단계");
            Console.WriteLine("==============================");
            Console.WriteLine("맵을 선택하세요.");
        }

        public void CreateMonster(int input)
        {
            m_Monster = new Monster();
            switch(input)
            {
                case 1:
                    m_Monster.strName = "하수몹";
                    m_Monster.iHP = 30;
                    m_Monster.iAttack = 3;
                    break;
                case 2:
                    m_Monster.strName = "중수몹";
                    m_Monster.iHP = 60;
                    m_Monster.iAttack = 6;
                    break;
                case 3:
                    m_Monster.strName = "고수몹";
                    m_Monster.iHP = 90;
                    m_Monster.iAttack = 9;
                    break;
            }
        }

        public void Fight()
        {
            while (true)
            {
                Console.Clear();
                m_Player.Render();
                m_Monster.Render();
                Console.WriteLine("1.전투 2. 도망");
                int iInput = int.Parse(Console.ReadLine());
                if (iInput == 1)
                {
                    m_Player.SetDamage(m_Monster);
                    m_Monster.SetDamage(m_Player);

                    if(m_Player.iHP <=0)
                    {
                        m_Player.iHP = 100;
                        break;
                    }

                    if (iInput == 2 || m_Monster.iHP <=0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
