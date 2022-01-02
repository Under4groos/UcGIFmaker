using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace UcGifConverter.Lib
{
    public class GifFrames
    {
        public  string PATH
        {
            get;private set;
        }
        private Image[] IMAGES;
        private Image image_gif;
        public int Count
        {
            get;set;
        }
        public GifFrames(string path)
        {
            if (!File.Exists(path)) return;
            PATH = path;
            image_gif = Image.FromFile(path);

            Count = image_gif.GetFrameCount(FrameDimension.Time);
            IMAGES = new Image[Count];
            for (int i = 0; i < Count; i++)
            {
                image_gif.SelectActiveFrame(FrameDimension.Time, i);
                IMAGES[i] = ((Image)image_gif.Clone());
            }
        }
        public Image GetFrame( int id )
        {
            if(Count > 0 && id <= Count)
                return IMAGES[id];
            return null;
        }
    }
}
