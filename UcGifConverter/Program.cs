using System;
using System.IO;
using UcGifConverter.Lib;

namespace UcGifConverter
{
    public static class StructCon
    {
        public static Enum.EnumConverter.EnumType EnumType { get; set; }
        public static string path_image;
        public static string path_gif;
    }
    internal class Program
    {


        static void Main(string[] args_)
        {

            StructCon.EnumType = Enum.EnumConverter.EnumType.images_to_gif;
            string[] start_text = new string[]
                {
                    "\"gi\" - gif to images",
                    "\"ig\" - images to gif",
                    "\"help\" - help!"
                };
            Log.add(start_text, Log.LogMode.ALL_2);

            while (true)
            {
                string str_ = Console.ReadLine();
                switch (str_.Trim())
                {
                    case "gi":
                        StructCon.EnumType = Enum.EnumConverter.EnumType.gif_to_images;

                        string path_gif = Console.ReadLine();
                        if (File.Exists(path_gif))
                        {
                            StructCon.path_gif = path_gif;
                        }
                            

                        string path = Console.ReadLine();
                        if (File.Exists(path))
                        {
                            StructCon.path_image = path;
                        }
                            


                        break;
                    case "ig":
                        StructCon.EnumType = Enum.EnumConverter.EnumType.gif_to_images;

                        break;
                    case "help":
                        Log.new_line = true;
                        Log.add(start_text, Log.LogMode.ALL_2);
                        Log.new_line = false;
                        break;
                    case "exit":
                        return;
                    default:
                        break;

                }

            }


            #region hide
            //Log.add(args, Log.LogMode.ALL);

            //string[]  args = string.Join(" ", args_).Split(new char[] { '-' });
            //Log.add(args, Log.LogMode.ALL);

            // [1] path_gif
            // "-images_git.gif -image_png%.png {10,1020,300}"
            // "-(gif img) -images_git.gif -image_png%.png"
            //LogColor.Set(255, 0, 0);

            //switch (args[1].Trim())
            //{
            //    case "(gif img)":


            //        Log.add(args[1], Log.LogMode.ERROR);

            //        string path_gif = args[2];
            //        string path_images = args[3];
            //        if( File.Exists(path_gif) && File.Exists(path_images))
            //        {
            //            Log.add(path_gif, Log.LogMode.ERROR);
            //            Log.add(path_images, Log.LogMode.ERROR);
            //        }



            //        break;
            //    case "(img gif)":
            //        Log.add(args[1], Log.LogMode.ERROR);

            //        break;
            //    default:
            //        break;
            //} 
            #endregion
            #region logic
            //GifFrames gifFrames = new GifFrames(@"C:\Users\UnderKo\source\repos\ConsoleApp2\ConsoleApp2\bin\Debug\mygif.gif");
            //Console.WriteLine(gifFrames.Count); 
            #endregion


        }
    }
}
