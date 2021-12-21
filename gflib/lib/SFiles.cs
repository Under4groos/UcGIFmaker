using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gflib.lib
{
    public static class SFiles
    {
        public static void file_rename(string file , string rename_file )
        {
          
          
            System.IO.FileInfo fi = new System.IO.FileInfo(file);
            
            if (fi.Exists)
            {
                
                fi.MoveTo(rename_file);
                while (true)
                {
                    if( !File.Exists(file))
                        break;
                    File.Delete(file);
                }

            }
        }
    }
}
