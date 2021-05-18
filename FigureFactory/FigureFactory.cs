using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    static class FigureFactory
    {
        public static Figure GetFigure(string shape)
        {
            if (shape == "Straight") return new StraightTetromino();
            if (shape == "Square") return new SquareTetromino();
            if (shape == "T") return new TTetromino();
            if (shape == "L") return new LTetromino();
            if (shape == "Skew") return new SkewTetromino();
            return null;
        }
    }
}
