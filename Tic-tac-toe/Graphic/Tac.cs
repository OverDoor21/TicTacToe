using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tic_tac_toe.Graphic
{
     public class Tac
     {
        Line line = new();

        public void DrawTac()
        {
            line.X1 = 50; // Начальная точка по X
            line.Y1 = 20; // Начальная точка по Y
            line.X2 = 50; // Конечная точка по X
            line.Y2 = 80; // Конечная точка по Y
            line.Stroke = Brushes.Black; // Цвет линии
            line.StrokeThickness = 2;
        }
     }
}
