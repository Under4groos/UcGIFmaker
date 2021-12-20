using FullUcLib;
using FullUcLib.func;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Ink;
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
         

     
        public Size SizeScreen
        {
            get
            {
                return new Size(SystemParameters.PrimaryScreenWidth, SystemParameters.PrimaryScreenHeight);
            }
        }
        void SetCustomCursor( Point p , double s , Color c )
        {
            EllipseCursor.Height = EllipseCursor.Width = s;
           

            EllipseCursor.Stroke = new SolidColorBrush(c);
            EllipseCursor.Margin = new Thickness(
                p.X - EllipseCursor.Width * 2,
                p.Y - EllipseCursor.Height * 2 ,
                0.1, 0.1
                );
        }
        public MainWindow()
        {
            InitializeComponent();
            Setting.OpenSetting();
            grid_setting.SetVis(false);

            this.Left = 0;
            this.Top = 0;
            this.Width = SizeScreen.Width;
            this.Height = SizeScreen.Height;

            StylusApi stylusApi = new StylusApi(PanelInkCanvas , DrawingAttributes_);
             


            TimerTick timerTick = new TimerTick();
            timerTick.Tick += (s, e) =>
            {
                if (System.Windows.Input.Keyboard.IsKeyDown(Key.Escape))
                {
                    Setting.SaveSetting();
                    this.Close();
                }
                if(System.Windows.Input.Keyboard.IsKeyDown(Key.LeftCtrl) && stylusApi.CurKeyDown == Key.Z)
                {
                    if (PanelInkCanvas.Strokes.Count != 0)
                        PanelInkCanvas.Strokes.RemoveAt(PanelInkCanvas.Strokes.Count - 1);
                    stylusApi.CurKeyDown = Key.F24;
                }
                switch (stylusApi.ActiveDevice)
                {
                    case DeviceType.Mouse:

                        StylusButtonState.SetText(0, $"Mouse state: ");
                        StylusButtonState.SetText(1, $"<{stylusApi.MouseLeftButtonDown}>");

                        StylusCurPos.SetText(
                            0,
                            $"Cursor pos: ");
                        StylusCurPos.SetText(
                            1,
                            $" {stylusApi.CursorPosition }");


                        break;
                    case DeviceType.Stylus:
                        StylusButtonState.SetText(0, "Stylus state: ");
                       

                        StylusButtonState.SetText(1, $" <{stylusApi.StylusButtonState}>");

                        StylusCurPos.SetText(
                            1,
                            stylusApi.StylusButtonState ? $" <{stylusApi.StylesPosition}>" : $" Air <{stylusApi.StylusInAirPosition}>");


                        //SetCustomCursor(stylusApi.StylesPosition, stylusApi.pen.size, Color.FromRgb(0, 116, 255));
                        

                        break;
                    default:
                        break;
                }
                ActiveDevice.SetText(1, $" <{stylusApi.ActiveDevice}>");

                PenSize.SetText(1, $" <{stylusApi.pen.size}>");



                

            };
            timerTick.Start();

         


            this.Loaded += (o, e) =>
            {
                DrawC();
                
                 
                ActiveDevice.add("Device: : ", Color.FromRgb(77, 77, 77), 15);
                ActiveDevice.add(" ", Color.FromRgb(0, 0, 0), 15);

                StylusButtonState.add("ButtonState: ", Color.FromRgb(77, 77, 77), 15);
                StylusButtonState.add(" <nil>", Color.FromRgb(0, 0, 0), 15);

                StylusCurPos.add("Stylus pos: ", Color.FromRgb(77, 77, 77), 15);
                StylusCurPos.add("(0,0)", Color.FromRgb(0, 0, 0), 15);

                PenSize.add("Pen size: ", Color.FromRgb(77, 77, 77), 15);
                PenSize.add("0", Color.FromRgb(0, 0, 0), 15);
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
                            new Size(4,4),
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

            saveFileDialog1.Filter = "image files (*.png)|*.png";
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

        private void b_mosue_down_op_setting(object sender, MouseButtonEventArgs e)
        {

            grid_setting.SetVis(!grid_setting.GetVis());

            grid_informations.SetVis(!grid_setting.GetVis());
        }

        private void Border_PreviewMouseLeftButtonDown_undo(object sender, MouseButtonEventArgs e)
        {
            
            if(PanelInkCanvas.Strokes.Count != 0)
                PanelInkCanvas.Strokes.RemoveAt(PanelInkCanvas.Strokes.Count - 1);
        }
    }
}
