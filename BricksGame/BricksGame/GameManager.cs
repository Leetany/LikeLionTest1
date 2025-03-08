using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BricksGame
{
    class GameManager
    {
        Ball m_pBall = null;
        Bar m_pBar = null;
        public Block m_pBlock = null;

        public void Initialize()
        {
            if(m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }

            //바
            if(m_pBar == null)
            {
                m_pBar = new Bar();
                m_pBar.Initialize();
            }

            if(m_pBlock == null)
            {
                m_pBlock = new Block();
                m_pBlock.Initialize(20);
            }

            //볼에서 바와 벽돌을 사용해야 할 거 같다.
            m_pBall.SetBar(m_pBar);
            m_pBall.SetBlock(m_pBlock);
        }

        public void Progress()
        {
            m_pBall.Progress();
            m_pBar.Progress(ref m_pBall);
            m_pBlock.Progress(20);
            
        }

        public void Render()
        {
            Console.Clear();
            m_pBall.Render();
            m_pBar.Render();
            m_pBlock.Render();
            
        }

        public void Release()
        {
            m_pBall.Release();
            m_pBar.Release();
        }
    }
}
