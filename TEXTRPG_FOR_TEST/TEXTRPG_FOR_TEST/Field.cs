using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_FOR_TEST
{
    public class Field
    {
        Player player = null;
        Monster monster = null;

        public void SetPlayer(Player _player) { player = _player; }

        public void Progress()
        {
            while(true)
            {
                Console.Clear();
                player.Render();
                DrawMap();
                int iInput = int.Parse(Console.ReadLine());

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
            monster = new Monster();

            switch(input)
            {
                case 1:
                    monster.strName = "하수몹";
                    monster.iHP = 30;
                    monster.iAttack = 3;
                    break;
                case 2:
                    monster.strName = "중수몹";
                    monster.iHP = 60;
                    monster.iAttack = 6;
                    break;
                case 3:
                    monster.strName = "고수몹";
                    monster.iHP = 90;
                    monster.iAttack = 9;
                    break;
            }
        }

        public void Fight()
        {
            while(true)
            {
                Console.Clear();
                player.Render();
                monster.Render();

                Console.WriteLine("1.싸운다 2.도망간다");
                int iInput = int.Parse(Console.ReadLine());

                if (iInput == 2) break;

                if(iInput ==1)
                {
                    player.SetDamage(monster);
                    monster.SetDamage(player);

                    if(player.iHP <=0)
                    {
                        player.iHP = 100;
                        break;
                    }

                    if (monster.iHP <= 0)
                    {
                        break;
                    }
                    
                }

            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1.하수맵");
            Console.WriteLine("2.중수맵");
            Console.WriteLine("3.고수맵");
            Console.WriteLine("4.전단계");
            Console.WriteLine("==============================================");
            Console.WriteLine("맵을 고르시오.");
        }
    }
}
