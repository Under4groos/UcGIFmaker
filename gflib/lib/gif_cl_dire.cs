
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gflib.lib
{
    public class gif_cl_dire
    {
        public gif_cl_dire(string path, string name_gif)
        {
            string[] files_ = Directory.GetFiles(path);

            using (AnimatedGif.AnimatedGifCreator gif = AnimatedGif.AnimatedGif.Create(name_gif, 30))
            {

                foreach (string item in files_)
                {

                    gif.AddFrame(Image.FromFile(item), 100, quality: AnimatedGif.GifQuality.Default);

                }

            }

        }
    }
}
