using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using UcGIFmaker.Lib;

namespace UcGIFmaker.Controls
{
    internal class DFIcon : Label
    {
        public DFIcon()
        {
             
            this.FontFamily = new System.Windows.Media.FontFamily("Segoe MDL2 Assets");
           
        }
 
        public Color HoverColor
        {
            get;set;
        }
        public Color BackgroundColor
        {
            get;set;
        }

        public string SetColorText
        {
            get
            {
                return (this.Foreground as SolidColorBrush).Color.ToString();
            }
            set
            {

                this.Foreground = new SolidColorBrush(RGBColor.StringToRGBColor(value));
            }
        } 
        public object IconID
        {
            get
            {
                return this.GetValue(ContentProperty);
            }
            set
            {
                SetValue(ContentProperty, value);
            }
        }
 
    }
}
