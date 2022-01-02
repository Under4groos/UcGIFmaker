using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UcGIFmaker.Controls
{
    public class DGrid : Grid
    {
        Border border;
        Grid grid_;
        public DGrid()
        {
            border = new Border()
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
                VerticalAlignment = System.Windows.VerticalAlignment.Stretch,
            };
            grid_ = new Grid()
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
                VerticalAlignment = System.Windows.VerticalAlignment.Stretch,
            };
            this.Children.Add(border);
            this.Children.Add(grid_);
        }
        public int Add(FrameworkElement frameworkElement)
        {
            return grid_.Children.Add(frameworkElement);
        }
        public Thickness BorderThickness
        {
            get
            {
                return border.BorderThickness;
            }
            set
            {
                border.BorderThickness = value;
            }
        }
        public CornerRadius Corner_Radius
        {
            get
            {
                return border.CornerRadius;
            }
            set
            {
                border.CornerRadius = value;
            }
        }

        public Brush BorderBrush
        {
            get
            {
                return border.BorderBrush;
            }
            set
            {
                border.BorderBrush = value;
            }
        }

        public double Alpha
        {
            get
            {
                return this.Opacity;
            }
            set
            {
                this.Opacity = value;
            }
        }
    }
}
