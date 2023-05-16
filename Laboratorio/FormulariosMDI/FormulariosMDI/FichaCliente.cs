using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosMDI
{
    public partial class FichaCliente : Form
    {
        public Cliente cliente { get; set; }
        public int id { get; set; }

        public GrillaClientes Grilla { get; set; }
        public FichaCliente()
        {
            InitializeComponent();
        }

        private void FichaCliente_Load(object sender, EventArgs e)
        {
            
            if (this.cliente!=null)
            {
                textBid.Text = cliente.id.ToString();
                textBNombre.Text = cliente.nombre;
                textBTelefono.Text = cliente.telefono;
                textBEmail.Text = cliente.email;
                this.id = cliente.id;

            }
            else
            {
                textBid.Text = this.id.ToString();
            }

            textBid.ReadOnly = true;

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.cliente = new Cliente(this.id,textBNombre.Text,
                textBTelefono.Text,textBEmail.Text);
            this.Grilla.clienteEnGrilla = new Cliente(this.id, textBNombre.Text,
                textBTelefono.Text, textBEmail.Text);

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
