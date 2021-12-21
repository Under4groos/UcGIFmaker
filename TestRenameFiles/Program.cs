using gflib.lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRenameFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            while (true)
            {
                switch (Console.ReadLine().ToLower())
                {
                    
                    case "/renamefiles":
                        Console.WriteLine("Directory ... ");
                        string path = Console.ReadLine();
                        if (Directory.Exists(path))
                        {
                            int count_ = 0;
                            foreach (string item in Directory.GetFiles(path))
                            {
                               
                                string newFile_ = Path.Combine(new FileInfo(item).DirectoryName, $"image_{count_}_" + new FileInfo(item).Extension);
                                count_++;
                                if( !File.Exists(newFile_))
                                {
                                    System.IO.File.Move(item, newFile_);
                                    
                                }
                                    
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(item);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("->" + newFile_);
                            }
                        }
                            
                        break;
                    case "/renamefile":
                        Console.WriteLine("File ... ");
                        string path_l = Console.ReadLine().Replace("\"" , "");
                        Console.WriteLine("New name file ... ");
                        string new_name_file = Console.ReadLine();
                        if(File.Exists(path_l))  
                            System.IO.File.Move(path_l,

                                 Path.Combine(new FileInfo(path_l).DirectoryName, $"{new_name_file}" + new FileInfo(path_l).Extension)
                        );

                        break;


                }
            }
        }
    }
}
