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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.rdbVivienda = new System.Windows.Forms.RadioButton();
            this.rdbCondominio = new System.Windows.Forms.RadioButton();
            this.rdbDepartamento = new System.Windows.Forms.RadioButton();
            this.lblCuartos = new System.Windows.Forms.Label();
            this.txtCuartos = new System.Windows.Forms.TextBox();
            this.lblParques = new System.Windows.Forms.Label();
            this.txtParques = new System.Windows.Forms.TextBox();
            this.lblEscuelas = new System.Windows.Forms.Label();
            this.txtEscuelas = new System.Windows.Forms.TextBox();
            this.lblBaños = new System.Windows.Forms.Label();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCentrosComerciales = new System.Windows.Forms.TextBox();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(219, 9);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(517, 117);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "Bienvenidos a ventas de casas UIO,\r\n    encuentra la casa de tus sueños\r\n\r\n";
            this.lblBienvenidos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(69, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ingresa tu nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(236, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(69, 172);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(158, 18);
            this.lblPresupuesto.TabIndex = 3;
            this.lblPresupuesto.Text = "Ingresa tu presupuesto";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(236, 168);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(202, 22);
            this.txtPresupuesto.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(69, 222);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(125, 18);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Ingresa el modelo";
            // 
            // rdbVivienda
            // 
            this.rdbVivienda.AutoSize = true;
            this.rdbVivienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVivienda.Location = new System.Drawing.Point(236, 222);
            this.rdbVivienda.Name = "rdbVivienda";
            this.rdbVivienda.Size = new System.Drawing.Size(83, 22);
            this.rdbVivienda.TabIndex = 6;
            this.rdbVivienda.TabStop = true;
            this.rdbVivienda.Text = "Vivienda";
            this.rdbVivienda.UseVisualStyleBackColor = true;
            // 
            // rdbCondominio
            // 
            this.rdbCondominio.AutoSize = true;
            this.rdbCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCondominio.Location = new System.Drawing.Point(236, 248);
            this.rdbCondominio.Name = "rdbCondominio";
            this.rdbCondominio.Size = new System.Drawing.Size(110, 22);
            this.rdbCondominio.TabIndex = 7;
            this.rdbCondominio.TabStop = true;
            this.rdbCondominio.Text = "Condominio";
            this.rdbCondominio.UseVisualStyleBackColor = true;
            // 
            // rdbDepartamento
            // 
            this.rdbDepartamento.AutoSize = true;
            this.rdbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDepartamento.Location = new System.Drawing.Point(236, 274);
            this.rdbDepartamento.Name = "rdbDepartamento";
            this.rdbDepartamento.Size = new System.Drawing.Size(123, 22);
            this.rdbDepartamento.TabIndex = 8;
            this.rdbDepartamento.TabStop = true;
            this.rdbDepartamento.Text = "Departamento";
            this.rdbDepartamento.UseVisualStyleBackColor = true;
            // 
            // lblCuartos
            // 
            this.lblCuartos.AutoSize = true;
            this.lblCuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuartos.Location = new System.Drawing.Point(572, 119);
            this.lblCuartos.Name = "lblCuartos";
            this.lblCuartos.Size = new System.Drawing.Size(61, 18);
            this.lblCuartos.TabIndex = 9;
            this.lblCuartos.Text = "Cuartos";
            // 
            // txtCuartos
            // 
            this.txtCuartos.Location = new System.Drawing.Point(651, 111);
            this.txtCuartos.Multiline = true;
            this.txtCuartos.Name = "txtCuartos";
            this.txtCuartos.Size = new System.Drawing.Size(40, 44);
            this.txtCuartos.TabIndex = 10;
            // 
            // lblParques
            // 
            this.lblParques.AutoSize = true;
            this.lblParques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParques.Location = new System.Drawing.Point(572, 172);
            this.lblParques.Name = "lblParques";
            this.lblParques.Size = new System.Drawing.Size(63, 18);
            this.lblParques.TabIndex = 11;
            this.lblParques.Text = "Parques";
            // 
            // txtParques
            // 
            this.txtParques.Location = new System.Drawing.Point(651, 168);
            this.txtParques.Multiline = true;
            this.txtParques.Name = "txtParques";
            this.txtParques.Size = new System.Drawing.Size(40, 42);
            this.txtParques.TabIndex = 12;
            // 
            // lblEscuelas
            // 
            this.lblEscuelas.AutoSize = true;
            this.lblEscuelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscuelas.Location = new System.Drawing.Point(572, 228);
            this.lblEscuelas.Name = "lblEscuelas";
            this.lblEscuelas.Size = new System.Drawing.Size(69, 18);
            this.lblEscuelas.TabIndex = 13;
            this.lblEscuelas.Text = "Escuelas";
            // 
            // txtEscuelas
            // 
            this.txtEscuelas.Location = new System.Drawing.Point(651, 228);
            this.txtEscuelas.Multiline = true;
            this.txtEscuelas.Name = "txtEscuelas";
            this.txtEscuelas.Size = new System.Drawing.Size(40, 42);
            this.txtEscuelas.TabIndex = 14;
            // 
            // lblBaños
            // 
            this.lblBaños.AutoSize = true;
            this.lblBaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaños.Location = new System.Drawing.Point(742, 121);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(51, 18);
            this.lblBaños.TabIndex = 15;
            this.lblBaños.Text = "Baños";
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(838, 111);
            this.txtBaños.Multiline = true;
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(40, 44);
            this.txtBaños.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Centros \r\ncomerciales\r\n";
            // 
            // txtCentrosComerciales
            // 
            this.txtCentrosComerciales.Location = new System.Drawing.Point(838, 165);
            this.txtCentrosComerciales.Multiline = true;
            this.txtCentrosComerciales.Name = "txtCentrosComerciales";
            this.txtCentrosComerciales.Size = new System.Drawing.Size(40, 44);
            this.txtCentrosComerciales.TabIndex = 18;
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransporte.Location = new System.Drawing.Point(742, 229);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(80, 18);
            this.lblTransporte.TabIndex = 19;
            this.lblTransporte.Text = "Transporte";
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(838, 226);
            this.txtTransporte.Multiline = true;
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(40, 44);
            this.txtTransporte.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 827);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.txtCentrosComerciales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.lblBaños);
            this.Controls.Add(this.txtEscuelas);
            this.Controls.Add(this.lblEscuelas);
            this.Controls.Add(this.txtParques);
            this.Controls.Add(this.lblParques);
            this.Controls.Add(this.txtCuartos);
            this.Controls.Add(this.lblCuartos);
            this.Controls.Add(this.rdbDepartamento);
            this.Controls.Add(this.rdbCondominio);
            this.Controls.Add(this.rdbVivienda);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblBienvenidos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.RadioButton rdbVivienda;
        private System.Windows.Forms.RadioButton rdbCondominio;
        private System.Windows.Forms.RadioButton rdbDepartamento;
        private System.Windows.Forms.Label lblCuartos;
        private System.Windows.Forms.TextBox txtCuartos;
        private System.Windows.Forms.Label lblParques;
        private System.Windows.Forms.TextBox txtParques;
        private System.Windows.Forms.Label lblEscuelas;
        private System.Windows.Forms.TextBox txtEscuelas;
        private System.Windows.Forms.Label lblBaños;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCentrosComerciales;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.TextBox txtTransporte;
    }
}

