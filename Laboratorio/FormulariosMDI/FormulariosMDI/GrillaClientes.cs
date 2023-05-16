using System;
using System.IO;
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
    public partial class GrillaClientes : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();

        public Cliente clienteEnGrilla { get; set; }

        public GrillaClientes()
        {
            InitializeComponent();
        }

        private void GrillaClientes_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            FichaCliente f = new FichaCliente();
            //f.MdiParent = this.MdiParent;
            f.id = autoinc();
            f.ShowDialog();//ventana modal
            if (f.DialogResult==DialogResult.OK)
            {
                //MessageBox.Show(f.cliente.nombre);
                this.listaClientes.Add(f.cliente);
                refrescarGrilla();
            }
        }

        public void refrescarGrilla()
        {
            dataGridView1.DataSource = null;
            BindingSource bs = new BindingSource();
            bs.DataSource = this.listaClientes;
            dataGridView1.DataSource = bs.DataSource;
        }

        public int autoinc()
        {
            if (listaClientes.Count==0)
            {
                return 0;
            }
            else
            {
                List<Cliente> ordenada = listaClientes.OrderByDescending(a => a.id).ToList();
                return ordenada[0].id + 1;
            }
            



        }
        private void test_Click(object sender, EventArgs e)
        {
            this.listaClientes.Add(new Cliente(this.autoinc()
                ,"Pedro","12222121","pedro@pedro.com"));
            this.listaClientes.Add(new Cliente(this.autoinc()
                , "Pablo", "54555", "pedro@pedro.com"));
            this.listaClientes.Add(new Cliente(this.autoinc()
                , "Andrea", "898989", "pedro@pedro.com"));
            this.listaClientes.Add(new Cliente(this.autoinc()
                , "Juana", "787878", "pedro@pedro.com"));

            refrescarGrilla();


        }

        public Cliente getCliente()
        {
            Cliente c=null;

            if (dataGridView1.CurrentRow!=null)
            {
                try
                {
                    int id = int.Parse(dataGridView1.CurrentRow.
                            Cells["id"].Value.ToString());
                    c = listaClientes.FirstOrDefault(q => q.id == id);

                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un cliente");

                }

            }


            return c;

        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            FichaCliente f = new FichaCliente();
            f.cliente = getCliente();
            if (f.cliente!=null)
            {
                f.ShowDialog();
                if (f.DialogResult==DialogResult.OK)
                {
                    for (int i = 0; i < listaClientes.Count; i++)
                    {
                        if (listaClientes[i].id == f.id)
                        {
                            listaClientes[i].id = f.cliente.id;
                            listaClientes[i].nombre = f.cliente.nombre;
                            listaClientes[i].telefono = f.cliente.telefono;
                            listaClientes[i].email = f.cliente.email;
                            refrescarGrilla();
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay cliente que modificar");

            }
            
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (getCliente()!=null)
            {
                DialogResult d= MessageBox.Show("Desea borrar el cliente?", "", MessageBoxButtons.OKCancel);
                if (d==DialogResult.OK)
                {
                    listaClientes.Remove(getCliente());
                    refrescarGrilla();
                }
                
                
                
            }
            else
            {
                MessageBox.Show("No selecciono cliente");
            }
            
        }

        private void abrirUnaVez_Click(object sender, EventArgs e)
        {
            
            
        }

       

        private void ventanaModal_Click(object sender, EventArgs e)
        {
            FichaCliente f = new FichaCliente();
            f.ShowDialog();
            if (f.DialogResult==DialogResult.OK)
            {
                MessageBox.Show(f.cliente.nombre);
            }
        }

        private void VentanaAmodal_Click(object sender, EventArgs e)
        {
            FichaCliente f = Application.OpenForms.OfType<FichaCliente>().FirstOrDefault();

            if (f==null)
            {

                 f = new FichaCliente();
                 f.MdiParent = this.MdiParent;
                 f.Grilla = this;
                 f.Show();
                 
            }
            else
            {
                f.Focus();
                f.BringToFront();
            }

         

        }

        private void GrillaClientes_Activated(object sender, EventArgs e)
        {
            if (this.clienteEnGrilla!=null)
            {
                MessageBox.Show(this.clienteEnGrilla.nombre);
            }
           
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter="txt (*.txt)|*.txt|csv (*.csv)|*.csv| pato (*.pat)|*.pat";

            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (saveFileDialog1.FileName!=null)
                {
                    StreamWriter archivo = new StreamWriter(saveFileDialog1.FileName);
                    string linea = "";
                    foreach (Cliente item in listaClientes)
                    {
                        linea = item.id + "," + item.nombre + "," + item.telefono + "," + item.email + ",";
                       
                        archivo.WriteLine(linea);

                    }

                    archivo.Close();

                }
                
            }
           

        }

        private void AbrirArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter="txt (*.txt)|*.txt|csv (*.csv)| *.csv";

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (openFileDialog1.FileName!=null)
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string linea = "";
                    string[] renglon;
                    while ((linea = sr.ReadLine())!=null)
                    {
                        
                        renglon = linea.Split(',');
                        MessageBox.Show(linea);
                        listaClientes.Add(new Cliente(int.Parse(renglon[0]), renglon[1], renglon[2], renglon[3]));
                        refrescarGrilla();
                    }

                    sr.Close();



                }




            }



        }
    }
}
