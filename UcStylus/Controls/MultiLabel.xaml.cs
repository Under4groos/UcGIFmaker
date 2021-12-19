using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UcStylus.Controls
{
    /// <summary>
    /// Логика взаимодействия для MultiLabel.xaml
    /// </summary>
    public partial class MultiLabel : UserControl
    {
        public MultiLabel()
        {
            InitializeComponent();
        }
        public void Clear() => stackpanel_.Children.Clear();

        public void add(string str , Color color , double font_size)
        {
            Label l = new Label()
            {
                FontSize = font_size,
                Content = str,
                Foreground = new SolidColorBrush(color),
            };
            stackpanel_.Children.Add(l);
        }
        public void SetText( int id , string str)
        {
            int ID_ = 0;
            foreach (var item in stackpanel_.Children)
            {
                if(id == ID_)
                {
                    (item as Label).Content = str;
                    break;
                }
                ID_++;
            }
        }
    }
}
