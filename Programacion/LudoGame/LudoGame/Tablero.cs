using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGame
{
    public partial class Tablero : Form
    {
        public Tablero()
        {
            InitializeComponent();
        }

        private void lblJ2_Click(object sender, EventArgs e)
        {

        }
        public void TiroDado()
        {
            Thread.Sleep(200);
            pictureBox2.Image = Properties.Resources.D1;
            Thread.Sleep(200);
            pictureBox2.Image = Properties.Resources.D2;
            Thread.Sleep(200);
            pictureBox2.Image = Properties.Resources.D3;
            Thread.Sleep(200);
            pictureBox2.Image = Properties.Resources.D4;
            Thread.Sleep(200);
            pictureBox2.Image = Properties.Resources.D5;
            Thread.Sleep(200);
            pictureBox2.Image = Properties.Resources.D6;
            Thread.Sleep(200);
            Random rnd = new Random();
            int num = rnd.Next(1, 7);
            switch (num)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.D1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.D2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.D3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.D4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.D5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.D6;
                    break;
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Thread(TiroDado).Start();
         }
    }
}
