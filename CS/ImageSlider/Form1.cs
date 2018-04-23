using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageSlider
{
    public partial class Form1 : Form
    {
        int currentImageIndex = 0;
        Image[] images;

        public Form1()
        {
            this.images = CreateImages();
            InitializeComponent();
        }

        Image[] CreateImages()
        {
            return new Image[]{
                CreateImage(Color.Red),
                CreateImage(Color.Green),
                CreateImage(Color.Blue),
            };
        }

        Image CreateImage(Color color)
        {
            Bitmap bitmap = new Bitmap(100, 100);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }

        private void imageSlider1_CanGetNextPrevImage(object sender, DevExpress.XtraEditors.Controls.CanGetNextPrevImageEventArgs e)
        {
            if (e.IsNext) e.CanGetImage = (currentImageIndex < images.Length - 1);
            else e.CanGetImage = (currentImageIndex > 0);
        }

        private void imageSlider1_GetImage(object sender, DevExpress.XtraEditors.Controls.GetImageEventArgs e)
        {
            if (e.IsStartUp)
            {
                e.Image = images[0];
                return;
            }
            if (e.IsNext)
            {
                e.Image = images[currentImageIndex + 1];
                if (e.CurrentImageUpdated) ++currentImageIndex;
            }
            else if (e.IsPrev)
            {
                e.Image = images[currentImageIndex - 1];
                if (e.CurrentImageUpdated) --currentImageIndex;
            }
        }
    }
}
