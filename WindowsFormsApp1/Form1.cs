using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        string resimyolu;
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog op = new OpenFileDialog();

                op.DefaultExt = ".jpg";

                op.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.* ";

                op.ShowDialog();

                resimyolu = op.FileName;

                pictureBox1.Image = Image.FromFile(resimyolu);
                //bmp = new Bitmap(pictureBox1.Image);
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata\n" + ex, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // throw;
            }
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void medianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            //  deneme 4

            bmp = new Bitmap(pictureBox1.Image);

            Bitmap yeniresim = new Bitmap(bmp.Width, bmp.Height);

            int sablonboyutu = 7;

            int cap = (sablonboyutu - 1) / 2;

            for (int i = cap; i < bmp.Width-cap; i++)
            {
                for (int j = cap; j < bmp.Height-cap; j++)
                {
                    List<Color> renk = new List<Color>();

                    for (int x = -cap; x < cap; x++)
                    {
                        for (int y = -cap; y < cap; y++)
                        {
                            Color okunanrenk = bmp.GetPixel(i + x, j + y);

                            renk.Add(okunanrenk);
                        }
                    }

                    renk = renk.OrderBy(s => (s.R + s.G + s.B) / 3).ToList();

                    int deger = renk.Count();

                    int tp = (deger + 1) / 2;

                    yeniresim.SetPixel(i, j, renk[tp]);
                }
            }

            pictureBox1.Image = yeniresim;
        }

        private void orjinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            

           
        }

        private void negatifiniAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);

            Bitmap yeniresim = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color okunanrenk = bmp.GetPixel(i, j);

                    int r = 255 - okunanrenk.R;
                    int g = 255 - okunanrenk.G;
                    int b = 255 - okunanrenk.B;

                    Color donusenrenk = Color.FromArgb(r, g, b);
                    yeniresim.SetPixel(i, j, donusenrenk);
                }
            }

            pictureBox1.Image = yeniresim;
        }

        private void taşıma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            bmp = new Bitmap(pictureBox1.Image);

            Bitmap yeniresim = new Bitmap(bmp.Width, bmp.Height);

            int x = 0, y = 0;

            int tx = 50, ty = 25;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color okunanrenk = bmp.GetPixel(i, j);

                    x = tx + i;
                    y = ty + j;

                    if (x>0&&x<bmp.Width&&y>0&&y<bmp.Height)
                    {
                        yeniresim.SetPixel(x, y, okunanrenk);
                    }
                }

                pictureBox1.Image = yeniresim;
            }
        }

        private void grileştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);

            Bitmap yeniresim = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color okunanrenk = bmp.GetPixel(i, j);

                    int r = okunanrenk.R;
                    int g = okunanrenk.G;
                    int b = okunanrenk.B;

                    int ortalama = (r + g + b) / 3;

                    Color yenirenk = Color.FromArgb(ortalama, ortalama, ortalama);

                    yeniresim.SetPixel(i, j, yenirenk);
                }
            }

            pictureBox1.Image = yeniresim;
        }

        private void eğmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            bmp = new Bitmap(pictureBox1.Image);

            Bitmap yeniresim = new Bitmap(bmp.Width, bmp.Height);
            double x = 0, y = 0;

            double egmekatsayisi = 0.2;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color okunanrenk = bmp.GetPixel(i, j);

                    x = i;

                    y = -egmekatsayisi * i + j;

                    if (x>0&&x<bmp.Width&&y>0&&y<bmp.Height)
                    {
                        yeniresim.SetPixel(i, j, okunanrenk);
                    }
                }

                pictureBox1.Image = yeniresim;
            }
            }

        private void dikeyDöndürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            bmp = new Bitmap(pictureBox1.Image);
            int genislik = bmp.Width;
            int uzunluk = bmp.Height;
            Bitmap yeni = new Bitmap(genislik, uzunluk);
            int x = genislik / 2;
            int y = uzunluk / 2;
            for (int i = 1; i < genislik; i++)
            {
                for (int j = 1; j < uzunluk; j++)
                {


                    Color renk = bmp.GetPixel(i, j);

                    int x1 = Convert.ToInt16(-i + 2 * x);
                    int y1 = j;

                    yeni.SetPixel(x1, y1, renk);
                }
            }
            pictureBox1.Image = yeni;
        }

        private void yatayDöndürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);
            int genislik = bmp.Width;
            int uzunluk = bmp.Height;
            int x = genislik / 2;
            int y = uzunluk / 2;
            Bitmap yeni = new Bitmap(genislik, uzunluk);

            for (int i = 1; i < genislik; i++)
            {
                for (int j = 0; j < uzunluk; j++)
                {

                    Color renk = bmp.GetPixel(i, j);

                    int x1 = i;
                    int y1 = Convert.ToInt16(-j + 2 * y);

                    yeni.SetPixel(x1, y1, renk);
                }
            }
            pictureBox1.Image = yeni;

        }
    }
    }


