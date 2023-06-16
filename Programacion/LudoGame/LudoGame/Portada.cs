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
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Form ventana1 = new Jugabilidad();
            ventana1.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la Aplicacion?","Mensaje",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(opcion == DialogResult.OK)
            {
                Close();
            }

        }

        private void Portada_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
