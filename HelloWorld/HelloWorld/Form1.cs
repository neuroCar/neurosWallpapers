using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);
        string file = "";
        int idx = 0;
        Random rand = new Random();
        string wallpaperDir;
        string[] wallpapers;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 60000;
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            wallpaperDir = Path.Combine(Application.StartupPath, "wallpapers");
            wallpapers = Directory.GetFiles(wallpaperDir, "*.*");
            pictureBox1.Image = Image.FromFile(wallpapers[idx]);
            btnNxt.Click += (s, e) => change("inc");
            btnBack.Click += (s, e) => change("dec");
            btnRand.Click += (s, e) => change("rand");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)(numericUpDown1.Value * 60000);
        }

        private void enableSlideshow(object sender, EventArgs e)
        {
            if (checkSlide.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void slideshow(object sender, EventArgs e)
        {
            if (checkSlideRand.Checked)
            {
                change("rand");
            }
            else
            {
                change("inc");
            }
            SystemParametersInfo(20, 0, file, 3);
        }

        private void change(string action)
        {
            if (action == "inc") { if (idx == wallpapers.Length - 1) { idx = 0; } else { idx += 1; }; };
            if (action == "dec") { if (idx == 0) { idx = wallpapers.Length - 1; } else { idx -= 1; }; };
            if (action == "rand") { idx = rand.Next(0, wallpapers.Length); };
            file = wallpapers[idx];
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = Image.FromFile(file);
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(20, 0, file, 3);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            file = openFileDialog1.FileName;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = Image.FromFile(file);
        }
    }
}
