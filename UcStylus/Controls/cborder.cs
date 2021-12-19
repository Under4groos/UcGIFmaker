using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UcStylus.Controls
{
    internal class cborder : Border
    {
        
        public cborder( Size size , Point pos ,Color c)
        {
            this.Width = size.Width;
            this.Height = size.Height;
            this.Margin = new Thickness(pos.X , pos.Y , 0.1,0.1);
            this.Background = new SolidColorBrush(c);
            this.HorizontalAlignment = HorizontalAlignment.Left;
            this.VerticalAlignment = VerticalAlignment.Top;
            
        }
    }
}
