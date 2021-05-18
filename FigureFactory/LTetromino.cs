using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    class LTetromino : Figure
    {
        public LTetromino()
        {
            Name = "L Tetromino";
            Shape = new int[][]
            {
                new int[]{1,0,0,0},
                new int[]{1,0,0,0},
                new int[]{1,0,0,0},
                new int[]{1,1,1,1},
            };
            Color = new RGB(200, 200, 200);
        }
    }
}
