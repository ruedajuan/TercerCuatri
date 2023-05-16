
namespace FormulariosMDI
{
    partial class GrillaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.VentanaAmodal = new System.Windows.Forms.Button();
            this.ventanaModal = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.guardar = new System.Windows.Forms.Button();
            this.AbrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AbrirArchivo);
            this.panel1.Controls.Add(this.guardar);
            this.panel1.Controls.Add(this.VentanaAmodal);
            this.panel1.Controls.Add(this.ventanaModal);
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.Borrar);
            this.panel1.Controls.Add(this.Modificar);
            this.panel1.Controls.Add(this.Nuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 110);
            this.panel1.TabIndex = 0;
            // 
            // VentanaAmodal
            // 
            this.VentanaAmodal.Location = new System.Drawing.Point(558, 16);
            this.VentanaAmodal.Name = "VentanaAmodal";
            this.VentanaAmodal.Size = new System.Drawing.Size(84, 52);
            this.VentanaAmodal.TabIndex = 6;
            this.VentanaAmodal.Text = "ventana amodal";
            this.VentanaAmodal.UseVisualStyleBackColor = true;
            this.VentanaAmodal.Click += new System.EventHandler(this.VentanaAmodal_Click);
            // 
            // ventanaModal
            // 
            this.ventanaModal.Location = new System.Drawing.Point(467, 16);
            this.ventanaModal.Name = "ventanaModal";
            this.ventanaModal.Size = new System.Drawing.Size(69, 52);
            this.ventanaModal.TabIndex = 5;
            this.ventanaModal.Text = "Venta modal";
            this.ventanaModal.UseVisualStyleBackColor = true;
            this.ventanaModal.Click += new System.EventHandler(this.ventanaModal_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(363, 14);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 4;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(1177, 16);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(247, 15);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 2;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(148, 15);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(30, 15);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 0;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 547);
            this.dataGridView1.TabIndex = 4;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(663, 16);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 7;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // AbrirArchivo
            // 
            this.AbrirArchivo.Location = new System.Drawing.Point(756, 16);
            this.AbrirArchivo.Name = "AbrirArchivo";
            this.AbrirArchivo.Size = new System.Drawing.Size(75, 23);
            this.AbrirArchivo.TabIndex = 8;
            this.AbrirArchivo.Text = "Abrir";
            this.AbrirArchivo.UseVisualStyleBackColor = true;
            this.AbrirArchivo.Click += new System.EventHandler(this.AbrirArchivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 657);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "GrillaClientes";
            this.Text = "GrillaClientes";
            this.Activated += new System.EventHandler(this.GrillaClientes_Activated);
            this.Load += new System.EventHandler(this.GrillaClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button ventanaModal;
        private System.Windows.Forms.Button VentanaAmodal;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button AbrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}