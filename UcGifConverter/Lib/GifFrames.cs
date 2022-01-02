using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace UcGifConverter.Lib
{
    public class GifFrames
    {
        public string PATH
        {
            get; private set;
        }
        public Image[] IMAGES;
        private Image image_gif;
        public int Count
        {
            get; set;
        }
        public ImageFormat imageFormat
        {
            get; set;
        } = ImageFormat.Png;
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

        public void SaveImages(string path  )
        {
            if (!Directory.Exists(path)) return;
            int count_fr_ = 0;
            foreach (System.Drawing.Image item in this.IMAGES)
            {
                item.Save(
                    Path.Combine(
                        path,
                        $"image_{count_fr_}.{imageFormat.ToString().ToLower()}"
                    ),
                    imageFormat);
                count_fr_++;
            }
        }
        public Image GetFrame(int id)
        {
            if (Count > 0 && id <= Count)
                return IMAGES[id];
            return null;
        }
    }
}
