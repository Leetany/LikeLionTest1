using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_FOR_TEST
{
    public class MainGame
    {
        Player player;
        Field field;

        public void Initialize()
        {
            player = new Player();

            player.SelectJob();

        }

        public void Progress()
        {
            while (true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("1.사냥터 2.종료");
                int iInput = int.Parse(Console.ReadLine());

                if(iInput == 2)
                {
                    break;
                }

                if(iInput == 1)
                {
                    if (field == null)
                    {
                        field = new Field();
                        field.SetPlayer(player);
                    }
                    field.Progress();
                }
            }
        }
    }
}
