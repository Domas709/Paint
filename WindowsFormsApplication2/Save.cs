using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{ 
    public class Save
    {
        public event SaveHandler Save1;
        public EventArgs e = null;
        public delegate void SaveHandler(Save m, EventArgs e, Bitmap bmp);

        public void Start(Bitmap bmp)
        {
            Save1(this, e, bmp);
        }
    }
    public class Saver
    {
        public void Subscribe(Save m, Bitmap bmp)
        {
            m.Save1 += new Save.SaveHandler(SaveIt);
        }
        private void SaveIt(Save m, EventArgs e, Bitmap bmp)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.RestoreDirectory = true;
            dlg.FileName = "MyPicture.png";
            dlg.DefaultExt = "png";
            dlg.Filter = "png files (*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string directory = dlg.FileName;
                FileInfo fileInfo = new FileInfo(directory);
                bmp.Save(@directory, ImageFormat.Png);
            }
        }

    }
}
