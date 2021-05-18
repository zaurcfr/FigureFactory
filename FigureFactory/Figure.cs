using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    abstract class Figure
    {
        public string Name { get; set; }
        public int[][] Shape { get; set; }
        public RGB Color { get; set; }

        public void Show()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Shape[i][j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (Shape[i][j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write($"{Shape[i][j]} ");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}
