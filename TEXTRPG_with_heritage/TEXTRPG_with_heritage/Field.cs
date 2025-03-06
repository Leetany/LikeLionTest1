using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_with_heritage
{
    class Field
    {
        Player m_Player = null;
        Monster m_Monseter = null;

        public void SetPlayer(Player player) { m_Player = player; }

        public void Progress()
        {
            int iInput = 0;

            while (true)
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

        public void CreateMonster(int input)
        {
            m_Monseter = new Monster();

            switch(input)
            {
                case 1:
                    m_Monseter.strName = "하수몹";
                    m_Monseter.iHP = 30;
                    m_Monseter.iAttack = 3;
                    break;
                case 2:
                    m_Monseter.strName = "중수몹";
                    m_Monseter.iHP = 60;
                    m_Monseter.iAttack = 6;
                    break;
                case 3:
                    m_Monseter.strName = "고수몹";
                    m_Monseter.iHP = 90;
                    m_Monseter.iAttack = 9;
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
                m_Monseter.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    m_Player.SetDamage(m_Monseter);
                    m_Monseter.SetDamage(m_Player);

                    if (m_Player.iHP <= 0)
                    {
                        m_Player.iHP = 100;
                        break;
                    }

                    if (iInput == 2 || m_Monseter.iHP <= 0)
                    {
                        m_Monseter = null;
                        break;
                    }
                }
            }
        }
        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============================");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
