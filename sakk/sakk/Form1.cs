using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sakk
{


    public partial class Form1 : Form
    {

        static PictureBox[,] jatekter = new PictureBox[8, 8];
        static PictureBox aktBabu = new PictureBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void inditas_Click(object sender, EventArgs e)
        {
            nevellenorzes();
            gofullscreen();
        }

        private void gofullscreen()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void nevellenorzes()
        {
           /* string nev1 = jatekos1TBOX.Text;
            string nev2 = jatekos2TBOX.Text;

            if(nev1 == "" || nev2 == "")
            {
                MessageBox.Show("Adja meg a játékosok nevét!");
            }
            else
            {
               
            }*/

            gombeltuntetes();
            jatektergeneralas();
        }

        private void jatektergeneralas()
        {
            int x = 0;
            int y = 0;
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Size = new Size(800, 800);
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(this.ClientSize.Width / 2 - pictureBox1.Size.Width / 2, -100);
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BringToFront();
            this.Controls.Add(pictureBox1);

            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox palya = new PictureBox();
                    palya.Size = new Size(100, 100);
                    palya.Location = new Point(x , y);
                    palya.Name = $"{i}_{j}";
                   // palya.MouseClick += new MouseEventHandler(mozgatasClick);
                    if ((i + j) % 2 == 0)
                    {
                        palya.BackColor = Color.Purple;
                    }
                    else
                    {
                        palya.BackColor = Color.Pink;
                    }
                    pictureBox1.Controls.Add(palya);
                    jatekter[i, j] = palya;

                    x += 100;
                }

                x = 0;
                y += 100;
            }
            

        }

        private void gombeltuntetes()
        {
            jatekos1.Visible = false;
            jatekos2.Visible = false;
            jatekos1TBOX.Visible = false;
            jatekos2TBOX.Visible = false;
            inditas.Visible = false;
            title.Visible = false;
            szabalyok.Visible = false;
            kep.Visible = false;
        }

        private void szabalyok_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Sakk");
        }

        private void újraindításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
