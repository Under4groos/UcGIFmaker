using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace gflib.lib
{
    public static class LibControls
    {
        public static FrameworkElement SetPos(this FrameworkElement o , double x , double y)
        {
            o.Margin = new Thickness(x, y, 1, 1);
            return o;
        }
        public static Point GetPos(this FrameworkElement o)
        {
            return new Point(o.Margin.Left, o.Margin.Top);
        }
        // Уть нака!
        public static void SetSize(this FrameworkElement o , double w , double h)
        {
            o.Width  = w;
            o.Height = h;
        }
    }
}
