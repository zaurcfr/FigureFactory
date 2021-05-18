using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    class SquareTetromino : Figure
    {
        public SquareTetromino()
        {
            Name = "Square Tetromino";
            Shape = new int[][]
            {
                new int[]{0,0,0,0},
                new int[]{0,1,1,0},
                new int[]{0,1,1,0},
                new int[]{0,0,0,0},
            };
            Color = new RGB(50, 50, 50);
        }
    }
}
