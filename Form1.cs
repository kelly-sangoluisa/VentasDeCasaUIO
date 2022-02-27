using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasDeCasaUIO
{
    //estructuras persona
    public struct Persona
    {
        public string nombre { get; set; }
        public double presupuesto;
    }
    //estructura lugar
    public struct Lugar
    {
        public string sector { get; set; } //norte, sur, centro
        public int parques;
        public int escuelas;
        public int centrosComerciales;
        public int transporte;
    }
    //estructura casa
    public struct Casa
    {
        public Lugar lugarCasa;
        public string modelo { get; set; } //tipo departamento, vivienda, condominio 
        public int cuartos;
        public int banos;
        public string parqueaderos { get; set; }
        public string espacioVerdes { get; set; }
        public double precioCasa;
    }
    //estructura credito
    public struct Credito
    {
        public double presupuestoInicial;
        public int numeroCuotas;
        public int cuotasMaxima;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTransporte_Click(object sender, EventArgs e)
        {

        }

        private void rdbDepartamento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gboxModelo_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblComprar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Agradecimiento agradecimiento = new Agradecimiento();
            agradecimiento.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
