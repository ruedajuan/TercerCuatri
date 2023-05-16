
namespace FormulariosMDI
{
    partial class FichaCliente
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.textBid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(425, 324);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // textBid
            // 
            this.textBid.Location = new System.Drawing.Point(191, 86);
            this.textBid.Name = "textBid";
            this.textBid.Size = new System.Drawing.Size(309, 22);
            this.textBid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textBNombre
            // 
            this.textBNombre.Location = new System.Drawing.Point(191, 137);
            this.textBNombre.Name = "textBNombre";
            this.textBNombre.Size = new System.Drawing.Size(309, 22);
            this.textBNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // textBTelefono
            // 
            this.textBTelefono.Location = new System.Drawing.Point(191, 183);
            this.textBTelefono.Name = "textBTelefono";
            this.textBTelefono.Size = new System.Drawing.Size(309, 22);
            this.textBTelefono.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // textBEmail
            // 
            this.textBEmail.Location = new System.Drawing.Point(191, 227);
            this.textBEmail.Name = "textBEmail";
            this.textBEmail.Size = new System.Drawing.Size(309, 22);
            this.textBEmail.TabIndex = 7;
            // 
            // FichaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBid);
            this.Controls.Add(this.Aceptar);
            this.Name = "FichaCliente";
            this.Text = "FichaCliente";
            this.Load += new System.EventHandler(this.FichaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox textBid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBEmail;
    }
}