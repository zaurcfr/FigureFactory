using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    class StraightTetromino : Figure
    {
        public StraightTetromino()
        {
            Name = "Straight Tetromino";
            Shape = new int[][]
            {
                new int[]{1,1,1,1},
                new int[]{0,0,0,0},
                new int[]{0,0,0,0},
                new int[]{0,0,0,0},
            };
            Color = new RGB(100, 100, 100);
        }
    }
}
