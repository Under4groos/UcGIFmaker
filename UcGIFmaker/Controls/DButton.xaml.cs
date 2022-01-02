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

namespace UcGIFmaker.Controls
{
    /// <summary>
    /// Логика взаимодействия для DButton.xaml
    /// </summary>
    public partial class DButton : UserControl
    {
        public DButton()
        {
            InitializeComponent();
        }
        public string Text
        {
            get
            {
                return Label_content.Content as string;
            }
            set
            {
                Label_content.Content = value;
            }
        }
    }
}
