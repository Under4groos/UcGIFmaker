using FullUcLib;
using FullUcLib.func;
using Microsoft.Win32;
using System.Windows;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using UcStylus.Controls;
using UcStylus.lib;

namespace UcStylus
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color bu_ = Color.FromRgb(0, 116, 255);
        Color bu_2 = Color.FromRgb(255, 0, 0);
        Key cur_key_down = 0;
        double PaintSize
        {
            get
            {
                return (DrawingAttributes_.Width + DrawingAttributes_.Height) / 2;
            }
            set
            {
                DrawingAttributes_.Width = DrawingAttributes_.Height = value <= 0.01 ? 0.01 : value;
            }
        }
        public Size SizeScreen
        {
            get
            {
                return new Size(SystemParameters.PrimaryScreenWidth, SystemParameters.PrimaryScreenHeight);
            }
        }
         
        public MainWindow()
        {
            InitializeComponent();

            this.Left = 0;
            this.Top = 0;
            this.Width = SizeScreen.Width;
            this.Height = SizeScreen.Height;
            int tis = 0;

            TimerTick timerTick = new TimerTick();
            timerTick.Tick += (s, e) =>
            {
                if (System.Windows.Input.Keyboard.IsKeyDown(Key.Escape))
                    this.Close();
            };
            timerTick.Start();
             

            PanelInkCanvas.StylusMove += (o, e) =>
            {

                Point p = e.GetPosition(this);
                EllipseCursor.Stroke = new SolidColorBrush(bu_);
                EllipseCursor.Margin = new Thickness(
                    p.X - EllipseCursor.Width / 2,
                    p.Y - EllipseCursor.Height / 2,
                    0.1, 0.1
                    );


            };
            PanelInkCanvas.MouseMove += (o, e) =>
            {
                tis++;
                if (tis < 50) return;



                Point p = e.GetPosition(PanelInkCanvas);
                cursor_pos_.SetText(0, "Cursor: ");
                cursor_pos_.SetText(1, $" <{p.X},{p.Y}>");



                tis = 0;
            };
            PanelInkCanvas.KeyDown += (o, e) =>
            {
                cur_key_down = e.Key;
                inf_keydown.SetText(1, $" <{cur_key_down}> ");

                if (e.Key == Key.Escape)
                    this.Close();
            };
            PanelInkCanvas.KeyUp += (o, e) =>
            {
                inf_keydown.SetText(1, $" <nil> ");
            };

            PanelInkCanvas.MouseWheel += (o, e) =>
            {
                if (cur_key_down.ToString().ToLower() == "system")
                    PaintSize -= e.Delta * 0.01;
            };
            PanelInkCanvas.PreviewMouseLeftButtonDown += (o, e) =>
            {
                inf_drive.SetText(1, $" <Mosue>");
            };
            PanelInkCanvas.StylusInAirMove += (o, e) =>
            {
                Point p = e.GetPosition(this);
                EllipseCursor.Stroke = new SolidColorBrush(bu_2);
                EllipseCursor.Margin = new Thickness(
                    p.X - EllipseCursor.Width / 2,
                    p.Y - EllipseCursor.Height / 2,
                    0.1, 0.1
                    );
            };



            this.Loaded += (o, e) =>
            {
                DrawC();
                cursor_pos_.add("Cursor: ", Color.FromRgb(77, 77, 77), 15);
                cursor_pos_.add($" <0,0>", Color.FromRgb(0, 0, 0), 15);

                inf_drive.add("Device: ", Color.FromRgb(77, 77, 77), 15);
                inf_drive.add(" <nil>", Color.FromRgb(0, 0, 0), 15);

                inf_keydown.add("Key: ", Color.FromRgb(77, 77, 77), 15);
                inf_keydown.add(" <nil>", Color.FromRgb(0, 0, 0), 15);
            };
        }

        void DrawC()
        {
            grid_m.Children.Clear();

            int count_w = 25;
            int count_h = 25;

            int size_n = 20;

            int count_x = ((int)grid_m.ActualWidth / size_n);
            int count_y = ((int)grid_m.ActualHeight / size_n);

            double size_w = grid_m.ActualWidth / count_x;
            double size_h = grid_m.ActualHeight / count_y;




            for (int x = 0; x < count_x; x++)
            {

                for (int y = 0; y < count_y; y++)
                {



                    grid_m.Children.Add(
                        new cborder(
                            new Size(5, 5),
                            new Point(size_w / 4 + (x * size_w), size_w / 4 + (y * size_h)),
                            Color.FromArgb(100, 255, 255, 255)
                            )
                        );
                }
            }
        }

        private void Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // clear PanelInkCanvas
            PanelInkCanvas.Children.Clear();
            PanelInkCanvas.Strokes.Clear();
        }

        private void b_mosue_down_saveimage(object sender, MouseButtonEventArgs e)
        {
            RenderTargetBitmap renderTargetBitmap = PanelInkCanvas.RTBitmap((int)PanelInkCanvas.ActualWidth, (int)PanelInkCanvas.ActualHeight);

        
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "image files (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == true)
            {
                
                fsi_save.save(saveFileDialog1.FileName, renderTargetBitmap);
            }


            
        }

        private void Border_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            grid_dop.SetVis(!grid_dop.GetVis());
        }
    }
}
