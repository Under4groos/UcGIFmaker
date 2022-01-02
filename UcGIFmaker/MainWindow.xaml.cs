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
using UcAutoClicker.Lib;
using UcGIFmaker.Window;

namespace UcGIFmaker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();

             

            new WinResize(this).RightDown(border_resize);
            new WinDragMove(this)
            {
                TopDown = 25,
                LeftDown = 35 * 3,
            };
            new WBControl(this, minim, ACTIONS.SIZE_min);
            new WBControl(this, maxim, ACTIONS.SIZE_max , () =>
            {
                maint_Controls_grid.Margin = new Thickness(5);
            });
            new WBControl(this, closeim, ACTIONS.CLOSE);



        }
    }
}
