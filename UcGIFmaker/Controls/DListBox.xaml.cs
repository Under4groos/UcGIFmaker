using gflib.lib;
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
    /// Логика взаимодействия для DListBox.xaml
    /// </summary>
    public partial class DListBox : UserControl
    {
        public ScrollViewer ScrollViewer
        { 
            get
            { 
                return  this.GetTemplateChild("ScrollViewer") as ScrollViewer; 
            } 
        }
        public int Add(FrameworkElement frameworkElement)
        {
            return ListBox_it.Items.Add(frameworkElement);
        }
        public double SpeedScroling
        {
            get; set;

        } = 0.1;
        public DListBox()
        {
            InitializeComponent();

            
            Random random = new Random();
            this.PreviewMouseWheel += (o, e) =>
            {
                double HorizontalOffset_ = eScrollViewer.HorizontalOffset - e.Delta * SpeedScroling;
                Console.WriteLine(HorizontalOffset_);
                eScrollViewer.ScrollToHorizontalOffset(HorizontalOffset_);
                
            };
        }
        public void ResizeItemsHeight()
        {
            foreach (FrameworkElement item in ListBox_it.Items)
            {
                item.SetSize(this.Height, this.Height);
            }
        }
        public FrameworkElement GetItemId( int id )
        {
            return (FrameworkElement)ListBox_it.Items[id];
        }

        private void UserControl_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //e.Delta
            //ListBox_it.ScrollToVerticalOffset(ListBox_it.VerticalOffset - 3)
            //ListBox_it.sc
            //Console.WriteLine(e.Delta);
            //ScrollViewer.ScrollToHorizontalOffset( - e.Delta);
        }
    }
}
