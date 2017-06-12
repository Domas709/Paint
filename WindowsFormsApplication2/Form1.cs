using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Point lastPoint;
        List<string> ComboBox;
        private int x, y, i = 0;
        Pen myPen = new Pen(Color.Black);

        delegate void MDelegate(string s);

        private int X1 { get; set; }
        private int Y1 { get; set; }
        private int Mode { get; set; }
        public Form1()
        {
            InitializeComponent();
            ComboBox_Size();
            ComboBox_Color();
            bmp = new Bitmap(Panel.Width, Panel.Height);
            using (Graphics g = Graphics.FromImage(bmp))
                g.Clear(Color.White);

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, Panel, new object[] { true });
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
            Mode = 0;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Mode = 1;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            Mode = 2;
        }

        public void ComboBox_Size()
        {
            List<int> ComboBox = new List<int>();
            for (int i = 1; i <= 20; i++)
                ComboBox.Add(i);
            SizeComboBox.DataSource = new BindingSource(ComboBox, null);
        }

        public void ComboBox_Color()
        {
            int i = 1;
            string x = "x";
            string con = "x1";
            string configvalue1 = ConfigurationManager.AppSettings["x1"];
            ComboBox = new List<string>();
            while (ConfigurationManager.AppSettings[con] != null)
            {
                configvalue1 = ConfigurationManager.AppSettings[con];
                i++;
                con = x + i.ToString();
                ComboBox.Add(configvalue1);
            }
            ColorComboBox.DataSource = new BindingSource(ComboBox, null);
        }
        public int PenSize()
        {
            int size;
            if (SizeComboBox.Text == null) size = 3;
            else size = Convert.ToInt32(SizeComboBox.Text);
            return size;
        }
        public string PenColor()
        {
            string color;
            if (ColorComboBox.Text == null) color = "Black";
            else color = ColorComboBox.Text;
            return color;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bmp.Dispose();
                Bitmap bmp2 = new Bitmap(ofd.FileName);
                this.Controls.Add(Panel);
                Panel.Invalidate();
                bmp = bmp2;
            }
        }

        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(bmp);
            f2.ShowDialog();
        }

        private void EraseAllButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Panel.Invalidate();
            }
        }

        private void PaintButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.FromName(PenColor());
            int x1, x2, y1, y2;
            myPen.Width = PenSize();
            try
            {
                x1 = Convert.ToInt32(textBox1.Text);
                y1 = Convert.ToInt32(textBox2.Text);
                x2 = Convert.ToInt32(textBox3.Text);
                y2 = Convert.ToInt32(textBox4.Text);
                if (x1 < 0 || x2 < 0 || y1 < 0 || y2 < 0) throw new CustomException();
                using (Graphics g = Graphics.FromImage(bmp))
                    g.DrawLine(myPen, x1, y1, x2, y2);
                Panel.Invalidate();
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Irasykite visas koordinates\n" + formatException.Message);
            }
            catch (CustomException customException)
            {
                MessageBox.Show("Neigiami skaiciai negalimi\n" + customException.Message);
            }
        }

        private void InvertingButton_Click(object sender, EventArgs e)
        {
            Inverting color = new Inverting();
            color.ApplyInvert(bmp);
            Panel.Invalidate();
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (Mode == 1)
            {
                base.OnMouseClick(e);
                X1 = e.X;
                Y1 = e.Y;
                i++;
                if (i == 2)
                {
                    i = 0;
                    Pen myPen = new Pen(Color.FromName(PenColor()));
                    myPen.Width = PenSize();
                    using (Graphics g = Graphics.FromImage(bmp))
                        g.DrawLine(myPen, x, y, X1, Y1);
                    Panel.Invalidate();
                }
                x = X1;
                y = Y1;
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            myPen.Width = PenSize();
            if (e.Button == MouseButtons.Left && Mode == 0)
            {
                myPen.Color = Color.FromName(PenColor());
                using (Graphics g = Graphics.FromImage(bmp))
                    g.DrawLine(myPen, lastPoint, e.Location);
            }
            if (e.Button == MouseButtons.Left && Mode == 2)
            {
                myPen.Color = Color.White;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.DrawLine(myPen, lastPoint, e.Location);
                }
            }
            lastPoint = e.Location;
            Panel.Invalidate();
        }

        private void ResizePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = Int32.Parse(XResizeTextBox.Text);
                int y1 = Int32.Parse(YResizeTextBox.Text);
                Bitmap bmp1 = new Bitmap(x1, y1);
                Graphics g = Graphics.FromImage(bmp1);
                g.Clear(Color.White);
                Rectangle rec = new Rectangle(0, 0, x1, y1);
                g.DrawImage(bmp, 0, 0, rec, GraphicsUnit.Pixel);
                bmp = bmp1;
                Panel.Invalidate();
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Irasykite visas koordinates\n" + formatException.Message);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save m = new Save();
            Saver l = new Saver();
            l.Subscribe(m, bmp);
            m.Start(bmp);
            MDelegate DelA = delegate (string s) { MessageBox.Show(s); };
            DelA("Successfully saved.\nYou may now exit the program");
        }


    }
}







