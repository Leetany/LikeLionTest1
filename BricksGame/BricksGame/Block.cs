using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BricksGame
{
    public class Block
    {
        public BLOCKDATA[] m_tBlock = new BLOCKDATA[50];

        public static Random rand = new Random();

        public void Initialize(int BlockNum)
        {
            for(int i=0; i<m_tBlock.Length; i++)
            {
                m_tBlock[i] = new BLOCKDATA();
                m_tBlock[i].nX = 0;
                m_tBlock[i].nY = 0;
                m_tBlock[i].Exist = false;
            }

            for (int i = 0; i < BlockNum; i++)
            {
                m_tBlock[i].Exist = true;
                m_tBlock[i].nX = rand.Next(2, 66);
                m_tBlock[i].nY = rand.Next(2, 16);

            }
        }

        public void Progress(int BlockNum)
        {
            
        }

        public void Render()
        {
            for(int i = 0; i < 20; i++)
            {
                if (m_tBlock[i].Exist)
                {
                    Program.gotoxy(m_tBlock[i].nX, m_tBlock[i].nY);
                    Console.Write("▥");
                }
            }
        }
    }
}
