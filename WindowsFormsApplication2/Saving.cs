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
    public class Saving
    {
        public void SaveIt(Bitmap bmp2, List<string> duomenys)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.RestoreDirectory = true;
            dlg.FileName = "MyProject";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string directory = dlg.FileName;
                FileInfo fileInfo = new FileInfo(directory);
                Directory.CreateDirectory(directory);
                string name = Path.GetFileName(dlg.FileName);
                string directory2 = directory + @"\" + name + ".txt";
                directory += @"\" + name + ".png";
                bmp2.Save(@directory, ImageFormat.Png);
                using (StreamWriter file = new StreamWriter(@directory2))
                {
                    foreach (string line in duomenys)
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
