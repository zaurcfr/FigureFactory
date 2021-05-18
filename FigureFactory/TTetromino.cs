using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    class TTetromino : Figure
    {
        public TTetromino()
        {
            Name = "T Tetromino";
            Shape = new int[][]
            {
                new int[]{1,1,1,1},
                new int[]{0,1,1,0},
                new int[]{0,1,1,0},
                new int[]{0,1,1,0},
            };
            Color = new RGB(150, 150, 150);
        }
    }
}
