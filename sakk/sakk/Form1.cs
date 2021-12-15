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
        static PictureBox aktBabu;

        public Form1()
        {
            InitializeComponent();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            nevellenorzes();
            Size = new Size(1920, 1080);
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
            int x = this.ClientSize.Width / 2;
            int y = this.ClientSize.Height / 2;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox palya = new PictureBox();
                    palya.Size = new Size(100, 100);
                    palya.Location = new Point(x + 6, y);
                    palya.Name = $"{i}_{j}";
                   // palya.MouseClick += new MouseEventHandler(mozgatasClick);
                    if ((i + j) % 2 == 0)
                    {
                        palya.BackColor = Color.FromArgb(255, 216, 176);
                    }
                    else
                    {
                        palya.BackColor = Color.FromArgb(69, 40, 36);
                        palya.Enabled = false;
                    }
                    this.Controls.Add(palya);
                    jatekter[i, j] = palya;

                    x += 100;
                }

                x = this.ClientSize.Width / 2;
                y += 100;
            }
            aktBabu = new PictureBox();

        }

        private void gombeltuntetes()
        {
            label1.Visible = false;
            label2.Visible = false;
            jatekos1TBOX.Visible = false;
            jatekos2TBOX.Visible = false;
            startBTN.Visible = false;
        }
    }
}
