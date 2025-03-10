using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame_Self_Practice
{
    public class Ball
    {
        BALLDATA m_tBall = new BALLDATA();

        //C#공의 방향 배열 정의
        int[,] g_WallCollision = new int[4, 6]
        {
            { 3, 2, -1, -1, -1, 4},
            { -1, -1, -1, -1, 2, 1},
            { -1, 5, 4, -1, -1, -1},
            { -1, -1, 1, 0, 5, -1}
        };
    }
}
