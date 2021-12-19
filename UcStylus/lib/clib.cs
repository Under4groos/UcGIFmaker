using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UcStylus.lib
{
    internal static class clib
    {
        public static void SetVis(this UIElement ui , bool b )
        {
            ui.Visibility = b ? Visibility.Visible : Visibility.Collapsed;            
        }
        public static bool GetVis(this UIElement ui)
        {
            return ui.Visibility == Visibility.Visible ? true : false;// Visibility.Collapsed;
        }
    }
}
