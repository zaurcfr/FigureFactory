using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    class SkewTetromino : Figure
    {
        public SkewTetromino()
        {
            Name = "Skew Tetromino";
            Shape = new int[][]
            {
                new int[]{0,0,0,0},
                new int[]{0,1,1,1},
                new int[]{1,1,1,0},
                new int[]{0,0,0,0},
            };
            Color = new RGB(250, 250, 250);
        }
    }
}
