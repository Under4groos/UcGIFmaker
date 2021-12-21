using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;

namespace UcStylus.lib
{
    public class Pen
    {
        public Pen()
        {
            
        }
        public double size { get; set; } = 5;
        
        public double multipy 
        { 
            get; 
            set; 
        } = 0.01;

        public void SetPenSize( double Delta)
        {
            if (Setting.PenMode)
            {
                size += Delta * multipy;
            }
            else
            {
                size -= Delta * multipy;
            }
                
            size = size <= 0 ? 0.01 : size;
            Setting.PenSize = size;
        }
    }
    public enum DeviceType
    {
        Mouse = 1,
        Stylus = 2,
    }
    //Да, это говнокод 2.0
    public class StylusApi  
    {
        public Pen pen = new Pen();
       

        public bool StylusButtonState { get; set; }
        public bool StylusHovered { get; set; }
        public bool MouseLeftButtonDown { get; set; }
        public DeviceType ActiveDevice { get; set; } 
 

        public Point StylesPosition = new Point(0, 0);
        public Point StylusInAirPosition = new Point(0, 0);
        public Point CursorPosition = new Point(0, 0);
        public System.Windows.Input.Key CurKeyDown { get; set; }

        public StylusApi(InkCanvas inkCanvas , DrawingAttributes drawingAttributes)
        {

            pen.size = Setting.PenSize;
            drawingAttributes.Width = drawingAttributes.Height = pen.size;

            inkCanvas.StylusButtonDown += (o, e) =>
            {
                StylusButtonState = true;
                 
            };
            inkCanvas.StylusButtonUp += (o, e) =>
            {
                StylusButtonState = false;
            };
            inkCanvas.StylusMove += (o, e) =>
            {
                
                ActiveDevice = DeviceType.Stylus;
                StylesPosition = e.GetPosition(inkCanvas);
                
            };
            inkCanvas.StylusInAirMove += (o, e) =>
            {
                ActiveDevice = DeviceType.Stylus;
                StylusInAirPosition = e.GetPosition(inkCanvas);
                StylusHovered = true;
            };
            inkCanvas.MouseWheel += (o, e) =>
            {
                // resizing 
                if (CurKeyDown.ToString().ToLower() == "system")
                {
                    pen.SetPenSize(e.Delta);
                    drawingAttributes.Width = drawingAttributes.Height = pen.size;
                }
                    
            };
            inkCanvas.MouseMove += (o, e) =>
            {
                
                if (StylusButtonState || StylusHovered == true) return;
                ActiveDevice = DeviceType.Mouse;

                CursorPosition = e.GetPosition(inkCanvas); 
            };
            inkCanvas.KeyDown += (o, e) =>
            {
               
                CurKeyDown = e.Key;
            };
            inkCanvas.PreviewMouseLeftButtonDown += (o, e) =>
            {
                StylusHovered = false;
                MouseLeftButtonDown = true;
            };
            inkCanvas.PreviewMouseLeftButtonUp += (o, e) =>
            {
                MouseLeftButtonDown = false;
            };
        }
    }
}
