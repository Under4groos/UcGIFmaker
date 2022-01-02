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
        public int Count
        {
            get
            {
                return StackPanel_items.Children.Count;
            }
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
        public int Add(FrameworkElement item) => StackPanel_items.Children.Add(item);


        public void ResizeItemsHeight()
        {
            foreach (FrameworkElement item in StackPanel_items.Children)
            {
                item.SetSize(this.Height, this.Height);
            }
        }
        public FrameworkElement GetItemId( int id )
        {
            return (FrameworkElement)StackPanel_items.Children[id];
        }
 
    }
}
