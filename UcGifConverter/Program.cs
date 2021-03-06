using AnimatedGif;
using gflib.lib;
using System;
using System.Collections.Generic;
using System.IO;
using UcGifConverter.Lib;

namespace UcGifConverter
{
    public class StructCon
    {
        public  Enum.EnumConverter.EnumType EnumType { get; set; }
        public  string path_image;
        public  string path_gif;

        public override string ToString()
        {
            return $"{EnumType} {path_image} {path_gif}";

        }

    }
    internal class Program
    {
        static StructCon structCon = new StructCon();

        #region hide
        //static void SetPath_gif()
        //{
        //    Log.add("Path to gif:");
        //    string path_gif = Console.ReadLine().Replace("\"", "");
        //    if (File.Exists(path_gif))
        //    {
        //        structCon.path_gif = path_gif;
        //    }
        //    else
        //    {
        //        SetPath_gif();
        //    }


        //}
        //static void SetPath_image()
        //{
        //    Log.add("Path to image:");
        //    string path = Console.ReadLine().Replace("\"", "");
        //    if (File.Exists(path))
        //    {
        //        structCon.path_image = path;
        //    }
        //    else
        //    {
        //        SetPath_image();
        //    }
        //} 
        #endregion

        static string ConsoleReadLine()
        {
            return Console.ReadLine().Replace("\"", "");
        }
        static void Main(string[] args_)
        {

             
            string[] start_text = new string[]
                {
                    "\"gi\" - gif to images",
                    "\"ig\" - images to gif",
                    "\"exit\" ",
                     
                    "\"help\" - help!"
                };
            Log.add(start_text, Log.LogMode.ALL_2);

            while (true)
            {
 

                string str_ = ConsoleReadLine();
                switch (str_.Trim())
                {
                    case "gi":
                        #region Path to gif
                        Log.add("Path to gif:");
                        string path_gif = "";
                        void SetPath_gif()
                        {
                            path_gif = Console.ReadLine().Replace("\"", "");
                            if (!File.Exists(path_gif))
                                SetPath_gif();
                        }
                        SetPath_gif(); 
                        #endregion
                        #region Saved Image Directory
                        Log.add("Saved Image Directory :");
                        string directory_save_images = "";
                        void directory_save_images_func()
                        {
                            directory_save_images = ConsoleReadLine();
                            if (!Directory.Exists(directory_save_images)) directory_save_images_func();
                        }
                        directory_save_images_func(); 
                        #endregion

                        GifFrames gifFrames = new GifFrames(path_gif);
                        gifFrames.SaveImages(directory_save_images);

                        break;
                    case "ig":
                        #region Region ig
                        Log.add("Путь к новому файлу \"gifimages.gif\":");
                        string new_gif_file = Console.ReadLine().Replace("\"", "");
                        Log.add("Директория с изображениями:");
                        string Image_folder = "";
                        void folder_()
                        {
                            Image_folder = Console.ReadLine().Replace("\"", "");
                            if (!Directory.Exists(Image_folder)) folder_();
                        }
                        folder_();
                        List<string> files_image_ = new List<string>();
                        foreach (var item in Directory.GetFiles(Image_folder))
                        {
                            if (Table.HasValue(new string[] { ".png", ".jpeg", ".jpg" }, new FileInfo(item).Extension))
                            {
                                files_image_.Add(item);
                                Log.add($"add: {item} , count: {files_image_.Count}");
                            }
                        }
                        Log.add($"Folder: {new_gif_file}");
                        using (var gif = AnimatedGif.AnimatedGif.Create(new_gif_file, 33))
                        {
                            foreach (string file_image in files_image_)
                            {
                                if (File.Exists(file_image))
                                    gif.AddFrame(System.Drawing.Image.FromFile(file_image), 100, quality: GifQuality.Bit8);
                            }
                        } 
                        #endregion
                        break;
                    case "g_frame":
                        SetPath_gif();
                        GifFrames gf = new GifFrames(path_gif);
                        bool _ret_ = true;
                        while (_ret_)
                        {
                            switch (Console.ReadLine().Replace("\"", ""))
                            {
                                case "get_frames":
                                    Log.add($"-> Frames: {gf.Count}");
                                    
                                    break;
                                case "return":
                                    _ret_ = false;
                                    break;
                                default:
                                    break;
            
                            }
                        }

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
