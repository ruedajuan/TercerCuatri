using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGame
{
    public partial class Jugabilidad : Form
    {
        public Jugabilidad()
        {
            InitializeComponent();
        }

        private void Jugabilidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventana2 = new Tablero();
            ventana2.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ventana2 = new Tablero();
            ventana2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form ventana2 = new Tablero();
           ventana2.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
