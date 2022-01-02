using System;

namespace UcGifConverter.Lib
{
    public static class LogColor
    {
        public static System.ConsoleColor FromColor(int r, int g, int b)
        {
            int index = (r > 128 | g > 128 | b > 128) ? 8 : 0; // Bright bit
            index |= (r > 64) ? 4 : 0; // Red bit
            index |= (g > 64) ? 2 : 0; // Green bit
            index |= (b > 64) ? 1 : 0; // Blue bit
            return (System.ConsoleColor)index;
        }

    }
    public static class Log
    {

        public enum LogMode
        {
            ALL = 1,
            ERROR = 2,
            ALL_2 = 3,
        }
        public static bool new_line
        {
            get; set;
        } = false;
        public static void add(string str_ad, LogMode logMode = LogMode.ALL)
        {
            add(new string[] { str_ad }, logMode);
        }
        public static void add(string[] str_ad, LogMode logMode = LogMode.ALL)
        {
            if (str_ad.Length == 0) return;
            switch (logMode)
            {
                case LogMode.ALL:
                    for (int i = 0; i < str_ad.Length; i++)
                    {
                        // str_ad[0] == String.Empty?1:0
                        Console.Out.WriteLine($"[{i}]: {str_ad[i]}");

                    }

                    break;
                case LogMode.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine(string.Join(new_line==true?"\n":" ", str_ad));
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogMode.ALL_2:
                    for (int i = 0; i < str_ad.Length; i++)
                    {
                        // str_ad[0] == String.Empty?1:0
                        Console.Out.WriteLine($"{str_ad[i]}");

                    }
                    break;
                default:
                    break;
            }

        }

    }
}
