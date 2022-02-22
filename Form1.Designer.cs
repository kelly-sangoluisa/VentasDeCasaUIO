namespace VentasDeCasaUIO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(280, 32);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(334, 28);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "Bienvenidos a ventas de casas UIO";
            this.lblBienvenidos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(69, 100);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(114, 16);
            this.lblCompra.TabIndex = 1;
            this.lblCompra.Text = "Ingresa tu nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Location = new System.Drawing.Point(69, 149);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(143, 16);
            this.lblPresupuesto.TabIndex = 3;
            this.lblPresupuesto.Text = "Ingresa tu presupuesto";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(226, 143);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(202, 22);
            this.txtPresupuesto.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 827);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lblBienvenidos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtPresupuesto;
    }
}

