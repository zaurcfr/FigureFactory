using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose one:\nStraight\nSquare\nT\nL\nSkew\n");
                string choice = Console.ReadLine();


                Figure figure = FigureFactory.GetFigure(choice);
                Console.WriteLine(figure?.Name);
                figure?.Show();

                Console.ReadLine();
            }
        }
    }
}
