using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tic_tac_toe.Graphic
{
    public class Tic
    {
        Ellipse ellipse = new ();
        
        public void DrawEllipse()
        {
            ellipse.Width = 100; 
            ellipse.Height = 100;  
            ellipse.Stroke = Brushes.Red; 
            ellipse.StrokeThickness = 2;
        }
    }
}
