using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcStylus
{
    public static class Setting
    {
        public static bool PenMode = true;
        public static double PenSize = 5;

        public static void SaveSetting()
        {

            File.WriteAllText("UcStylusSetting.txt", $"{PenMode};{PenSize}");
        }
        public static void OpenSetting()
        {
            if (!File.Exists("UcStylusSetting.txt")) return;
            string r_str = File.ReadAllText("UcStylusSetting.txt");
            string[] ta_str = r_str.Split(';');

            Setting.PenMode = bool.Parse(ta_str[0]);
            Setting.PenSize = double.Parse(ta_str[1]);
        }
    }
}
