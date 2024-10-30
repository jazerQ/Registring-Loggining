using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    static class ImageConverter
    {
        public static ImageSource ConvertStringToImageSource(string imagePath)
        {
            // Создаем новый объект BitmapImage
            BitmapImage bitmap = new BitmapImage();

            // Устанавливаем путь к изображению
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            bitmap.Freeze(); // Замораживаем объект для повышения производительности

            return bitmap;
        }
    }
}
