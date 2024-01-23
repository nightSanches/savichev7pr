using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace savichev7pr.Classes
{
    public class Triangle : Figure
    {
        public Triangle(int x, int y) : base(x, y) { }
        public void DrawTriangle(Canvas z)
        {
            Polygon triangle = new Polygon();
            triangle.Stroke = Brushes.Black;
            triangle.Fill = Brushes.LightSeaGreen;
            triangle.StrokeThickness = 2;
            Point point1 = new Point(x, y);
            Point point2 = new Point(x + 50, y + 100);
            Point point3 = new Point(x + 100, y);
            PointCollection points = new PointCollection();
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            triangle.Points = points;

            z.Children.Add(triangle);
        }
    }
}
