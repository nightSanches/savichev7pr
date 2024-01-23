using savichev7pr.Classes;
using System;
using System.Windows;

namespace savichev7pr
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_Draw_Ellipse(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(x_coords.Text);
                int y = Convert.ToInt32(y_coords.Text);
                int d = Convert.ToInt32(diameter.Text);
                Ellipsee triangle = new Ellipsee(x, y, d);
                triangle.DrawCircle(canvas);
            }
            catch
            { }
        }

        private void Click_Draw_Triangle(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(x_coords.Text);
                int y = Convert.ToInt32(y_coords.Text);
                Triangle triangle = new Triangle(x, y);
                triangle.DrawTriangle(canvas);
            }
            catch
            { }
        }
    }
}
