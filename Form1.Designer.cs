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
            this.lblIngresaSector = new System.Windows.Forms.Label();
            this.rbtnSur = new System.Windows.Forms.RadioButton();
            this.rbtnCentro = new System.Windows.Forms.RadioButton();
            this.rbtnNorte = new System.Windows.Forms.RadioButton();
            this.lblParqueaderos = new System.Windows.Forms.Label();
            this.lblEspaciosVerdes = new System.Windows.Forms.Label();
            this.rbtnSiParqueaderos = new System.Windows.Forms.RadioButton();
            this.rbtnNoParqueaderos = new System.Windows.Forms.RadioButton();
            this.rbtnSiEspaciosVerdes = new System.Windows.Forms.RadioButton();
            this.rbtnNoEspaciosVerdes = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnIntenteDeNuevo = new System.Windows.Forms.Button();
            this.lblComprar = new System.Windows.Forms.Label();
            this.rbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIngresaSector
            // 
            this.lblIngresaSector.AutoSize = true;
            this.lblIngresaSector.Location = new System.Drawing.Point(55, 286);
            this.lblIngresaSector.Name = "lblIngresaSector";
            this.lblIngresaSector.Size = new System.Drawing.Size(85, 13);
            this.lblIngresaSector.TabIndex = 0;
            this.lblIngresaSector.Text = "Ingresa el sector";
            // 
            // rbtnSur
            // 
            this.rbtnSur.AutoSize = true;
            this.rbtnSur.Location = new System.Drawing.Point(167, 286);
            this.rbtnSur.Name = "rbtnSur";
            this.rbtnSur.Size = new System.Drawing.Size(41, 17);
            this.rbtnSur.TabIndex = 1;
            this.rbtnSur.TabStop = true;
            this.rbtnSur.Text = "Sur";
            this.rbtnSur.UseVisualStyleBackColor = true;
            this.rbtnSur.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnCentro
            // 
            this.rbtnCentro.AutoSize = true;
            this.rbtnCentro.Location = new System.Drawing.Point(214, 286);
            this.rbtnCentro.Name = "rbtnCentro";
            this.rbtnCentro.Size = new System.Drawing.Size(56, 17);
            this.rbtnCentro.TabIndex = 2;
            this.rbtnCentro.TabStop = true;
            this.rbtnCentro.Text = "Centro";
            this.rbtnCentro.UseVisualStyleBackColor = true;
            // 
            // rbtnNorte
            // 
            this.rbtnNorte.AutoSize = true;
            this.rbtnNorte.Location = new System.Drawing.Point(276, 286);
            this.rbtnNorte.Name = "rbtnNorte";
            this.rbtnNorte.Size = new System.Drawing.Size(51, 17);
            this.rbtnNorte.TabIndex = 3;
            this.rbtnNorte.TabStop = true;
            this.rbtnNorte.Text = "Norte";
            this.rbtnNorte.UseVisualStyleBackColor = true;
            // 
            // lblParqueaderos
            // 
            this.lblParqueaderos.AutoSize = true;
            this.lblParqueaderos.Location = new System.Drawing.Point(410, 286);
            this.lblParqueaderos.Name = "lblParqueaderos";
            this.lblParqueaderos.Size = new System.Drawing.Size(73, 13);
            this.lblParqueaderos.TabIndex = 4;
            this.lblParqueaderos.Text = "Parqueaderos";
            // 
            // lblEspaciosVerdes
            // 
            this.lblEspaciosVerdes.AutoSize = true;
            this.lblEspaciosVerdes.Location = new System.Drawing.Point(410, 309);
            this.lblEspaciosVerdes.Name = "lblEspaciosVerdes";
            this.lblEspaciosVerdes.Size = new System.Drawing.Size(86, 13);
            this.lblEspaciosVerdes.TabIndex = 5;
            this.lblEspaciosVerdes.Text = "Espacios Verdes";
            // 
            // rbtnSiParqueaderos
            // 
            this.rbtnSiParqueaderos.AutoSize = true;
            this.rbtnSiParqueaderos.Location = new System.Drawing.Point(516, 284);
            this.rbtnSiParqueaderos.Name = "rbtnSiParqueaderos";
            this.rbtnSiParqueaderos.Size = new System.Drawing.Size(34, 17);
            this.rbtnSiParqueaderos.TabIndex = 6;
            this.rbtnSiParqueaderos.TabStop = true;
            this.rbtnSiParqueaderos.Text = "Si";
            this.rbtnSiParqueaderos.UseVisualStyleBackColor = true;
            // 
            // rbtnNoParqueaderos
            // 
            this.rbtnNoParqueaderos.AutoSize = true;
            this.rbtnNoParqueaderos.Location = new System.Drawing.Point(558, 284);
            this.rbtnNoParqueaderos.Name = "rbtnNoParqueaderos";
            this.rbtnNoParqueaderos.Size = new System.Drawing.Size(41, 17);
            this.rbtnNoParqueaderos.TabIndex = 7;
            this.rbtnNoParqueaderos.TabStop = true;
            this.rbtnNoParqueaderos.Text = "NO";
            this.rbtnNoParqueaderos.UseVisualStyleBackColor = true;
            // 
            // rbtnSiEspaciosVerdes
            // 
            this.rbtnSiEspaciosVerdes.AutoSize = true;
            this.rbtnSiEspaciosVerdes.Location = new System.Drawing.Point(516, 309);
            this.rbtnSiEspaciosVerdes.Name = "rbtnSiEspaciosVerdes";
            this.rbtnSiEspaciosVerdes.Size = new System.Drawing.Size(34, 17);
            this.rbtnSiEspaciosVerdes.TabIndex = 8;
            this.rbtnSiEspaciosVerdes.TabStop = true;
            this.rbtnSiEspaciosVerdes.Text = "Si";
            this.rbtnSiEspaciosVerdes.UseVisualStyleBackColor = true;
            // 
            // rbtnNoEspaciosVerdes
            // 
            this.rbtnNoEspaciosVerdes.AutoSize = true;
            this.rbtnNoEspaciosVerdes.Location = new System.Drawing.Point(560, 307);
            this.rbtnNoEspaciosVerdes.Name = "rbtnNoEspaciosVerdes";
            this.rbtnNoEspaciosVerdes.Size = new System.Drawing.Size(39, 17);
            this.rbtnNoEspaciosVerdes.TabIndex = 9;
            this.rbtnNoEspaciosVerdes.TabStop = true;
            this.rbtnNoEspaciosVerdes.Text = "No";
            this.rbtnNoEspaciosVerdes.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(328, 327);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 356);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(585, 85);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnIntenteDeNuevo
            // 
            this.btnIntenteDeNuevo.Location = new System.Drawing.Point(633, 374);
            this.btnIntenteDeNuevo.Name = "btnIntenteDeNuevo";
            this.btnIntenteDeNuevo.Size = new System.Drawing.Size(84, 42);
            this.btnIntenteDeNuevo.TabIndex = 12;
            this.btnIntenteDeNuevo.Text = "Intente de nuevo";
            this.btnIntenteDeNuevo.UseVisualStyleBackColor = true;
            // 
            // lblComprar
            // 
            this.lblComprar.AutoSize = true;
            this.lblComprar.Location = new System.Drawing.Point(325, 444);
            this.lblComprar.Name = "lblComprar";
            this.lblComprar.Size = new System.Drawing.Size(72, 13);
            this.lblComprar.TabIndex = 13;
            this.lblComprar.Text = "Comprarla en:";
            // 
            // rbtnEfectivo
            // 
            this.rbtnEfectivo.AutoSize = true;
            this.rbtnEfectivo.Location = new System.Drawing.Point(276, 460);
            this.rbtnEfectivo.Name = "rbtnEfectivo";
            this.rbtnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbtnEfectivo.TabIndex = 14;
            this.rbtnEfectivo.TabStop = true;
            this.rbtnEfectivo.Text = "Efectivo";
            this.rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Location = new System.Drawing.Point(389, 460);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(58, 17);
            this.rbtnCredito.TabIndex = 15;
            this.rbtnCredito.TabStop = true;
            this.rbtnCredito.Text = "Crédito";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(565, 460);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(49, 13);
            this.lblCuotas.TabIndex = 16;
            this.lblCuotas.Text = "# cuotas";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(617, 457);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtCuotas.TabIndex = 17;
            this.txtCuotas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 672);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.rbtnCredito);
            this.Controls.Add(this.rbtnEfectivo);
            this.Controls.Add(this.lblComprar);
            this.Controls.Add(this.btnIntenteDeNuevo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rbtnNoEspaciosVerdes);
            this.Controls.Add(this.rbtnSiEspaciosVerdes);
            this.Controls.Add(this.rbtnNoParqueaderos);
            this.Controls.Add(this.rbtnSiParqueaderos);
            this.Controls.Add(this.lblEspaciosVerdes);
            this.Controls.Add(this.lblParqueaderos);
            this.Controls.Add(this.rbtnNorte);
            this.Controls.Add(this.rbtnCentro);
            this.Controls.Add(this.rbtnSur);
            this.Controls.Add(this.lblIngresaSector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresaSector;
        private System.Windows.Forms.RadioButton rbtnSur;
        private System.Windows.Forms.RadioButton rbtnCentro;
        private System.Windows.Forms.RadioButton rbtnNorte;
        private System.Windows.Forms.Label lblParqueaderos;
        private System.Windows.Forms.Label lblEspaciosVerdes;
        private System.Windows.Forms.RadioButton rbtnSiParqueaderos;
        private System.Windows.Forms.RadioButton rbtnNoParqueaderos;
        private System.Windows.Forms.RadioButton rbtnSiEspaciosVerdes;
        private System.Windows.Forms.RadioButton rbtnNoEspaciosVerdes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnIntenteDeNuevo;
        private System.Windows.Forms.Label lblComprar;
        private System.Windows.Forms.RadioButton rbtnEfectivo;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.TextBox txtCuotas;
    }
}

