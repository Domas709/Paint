using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint;

namespace Paint
{
    public partial class Form2 : Form
    {
        Bitmap bmp2;
        delegate void MDelegate(string s);
        int i = 0;
        public Form2(Bitmap bmp)
        {
            if (i == 0)
            {
                InitializeComponent();
                bmp2 = bmp;
                i++;
            }
        }
        
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            List<string> text = new List<string>();
            text.Add("Name:" + ProjectNameTextBox.Text);
            text.Add("Author:" + AuthorTextBox.Text);
            text.Add("Notes:" + NotesTextBox.Text);
            Saving file = new Saving();
            file.SaveIt(bmp2, text);
            MDelegate DelA = delegate (string s) { MessageBox.Show(s); };
            DelA("Successfully saved.\nYou may now exit the program");
            this.Close();
        }
    }
}



