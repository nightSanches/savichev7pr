using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace savichev7pr.Classes
{
    public class Ellipsee : Figure
    {
        public int diameter { get; set; }
        public Ellipsee(int x, int y, int diameter) : base(x, y)
        {
            this.diameter = diameter;
        }
        public void DrawCircle(Canvas z)
        {
            Ellipse circle = new Ellipse();
            circle.Width = diameter;
            circle.Height = diameter;
            circle.Fill = Brushes.Red;
            Canvas.SetLeft(circle, x);
            Canvas.SetTop(circle, y);

            z.Children.Add(circle);
        }
    }
}
