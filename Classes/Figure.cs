using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace savichev7pr.Classes
{
    public class Figure
    {
        public int x {  get; set; }
        public int y { get; set; }

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
