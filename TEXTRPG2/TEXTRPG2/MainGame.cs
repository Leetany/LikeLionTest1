using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG2
{
    class MainGame
    {
        //플레이어 객체
        public Player m_Player = null;
        //필드 객체
        public Field m_Field = null;

        public void Initialize()
        {
            //플레이어 생성 및 직업 선택
            m_Player = new Player();
            m_Player.SelectJob();
        }

        //게임의 전체적인 과정 관리
        public void Progress()
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear();
                m_Player.Render(); // 선택 후 플레이어 상태 출력
                Console.WriteLine("1.사냥터 2.종료 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2) break;

                if(iInput == 1)
                {
                    //사냥터 구현
                    if(m_Field == null)
                    {
                        m_Field = new Field(); //처음엔 null인 상태라 만들어 줘야 함
                        //필드로 갈 때 플레이어 넣어주기
                        m_Field.SetPlayer(ref m_Player);
                    }
                    m_Field.Progress();
                }
            }
        }

        public MainGame() { }
        ~MainGame() { }
    }
}
