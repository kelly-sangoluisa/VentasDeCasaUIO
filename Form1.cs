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
        int n = 30;
        bool encontrado;
        int busqueda;
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
            //COMIENZO DE RESGRITRO DE CASAS 
            Casa[] casasRegistradas = new Casa[30]; //constructor de arreglo de casas a vender
            //casas NORTE 
            casasRegistradas[0].lugarCasa.sector = "Norte";
            casasRegistradas[0].lugarCasa.parques = 1;
            casasRegistradas[0].lugarCasa.escuelas = 2;
            casasRegistradas[0].lugarCasa.centrosComerciales = 1;
            casasRegistradas[0].lugarCasa.transporte = 2;
            casasRegistradas[0].modelo = "Vivienda";
            casasRegistradas[0].cuartos = 4;
            casasRegistradas[0].banos = 2;
            casasRegistradas[0].parqueaderos = "Si";
            casasRegistradas[0].espacioVerdes = "No";
            casasRegistradas[0].precioCasa = 490000;
            //2
            casasRegistradas[1].lugarCasa.sector = "Norte";
            casasRegistradas[1].lugarCasa.parques = 1;
            casasRegistradas[1].lugarCasa.escuelas = 2;
            casasRegistradas[1].lugarCasa.centrosComerciales = 1;
            casasRegistradas[1].lugarCasa.transporte = 2;
            casasRegistradas[1].modelo = "Condominio";
            casasRegistradas[1].cuartos = 1;
            casasRegistradas[1].banos = 1;
            casasRegistradas[1].parqueaderos = "No";
            casasRegistradas[1].espacioVerdes = "No";
            casasRegistradas[1].precioCasa = 25000;
            //3
            casasRegistradas[2].lugarCasa.sector = "Norte";
            casasRegistradas[2].lugarCasa.parques = 2;
            casasRegistradas[2].lugarCasa.escuelas = 1;
            casasRegistradas[2].lugarCasa.centrosComerciales = 2;
            casasRegistradas[2].lugarCasa.transporte = 1;
            casasRegistradas[2].modelo = "Departamento";
            casasRegistradas[2].cuartos = 2;
            casasRegistradas[2].banos = 2;
            casasRegistradas[2].parqueaderos = "Si";
            casasRegistradas[2].espacioVerdes = "Si";
            casasRegistradas[2].precioCasa = 400000;
            //4
            casasRegistradas[3].lugarCasa.sector = "Norte";
            casasRegistradas[3].lugarCasa.parques = 0;
            casasRegistradas[3].lugarCasa.escuelas = 0;
            casasRegistradas[3].lugarCasa.centrosComerciales = 0;
            casasRegistradas[3].lugarCasa.transporte = 0;
            casasRegistradas[3].modelo = "Vivienda";
            casasRegistradas[3].cuartos = 4;
            casasRegistradas[3].banos = 2;
            casasRegistradas[3].parqueaderos = "No";
            casasRegistradas[3].espacioVerdes = "No";
            casasRegistradas[3].precioCasa = 25000;
            //5
            casasRegistradas[4].lugarCasa.sector = "Norte";
            casasRegistradas[4].lugarCasa.parques = 1;
            casasRegistradas[4].lugarCasa.escuelas = 1;
            casasRegistradas[4].lugarCasa.centrosComerciales = 1;
            casasRegistradas[4].lugarCasa.transporte = 1;
            casasRegistradas[4].modelo = "Departamento";
            casasRegistradas[4].cuartos = 1;
            casasRegistradas[4].banos = 1;
            casasRegistradas[4].parqueaderos = "Si";
            casasRegistradas[4].espacioVerdes = "Si";
            casasRegistradas[4].precioCasa = 100000;
            //6
            casasRegistradas[5].lugarCasa.sector = "Norte";
            casasRegistradas[5].lugarCasa.parques = 2;
            casasRegistradas[5].lugarCasa.escuelas = 2;
            casasRegistradas[5].lugarCasa.centrosComerciales = 1;
            casasRegistradas[5].lugarCasa.transporte = 2;
            casasRegistradas[5].modelo = "Condominio";
            casasRegistradas[5].cuartos = 3;
            casasRegistradas[5].banos = 2;
            casasRegistradas[5].parqueaderos = "No";
            casasRegistradas[5].espacioVerdes = "Si";
            casasRegistradas[5].precioCasa = 50000;
            //7
            casasRegistradas[6].lugarCasa.sector = "Norte";
            casasRegistradas[6].lugarCasa.parques = 0;
            casasRegistradas[6].lugarCasa.escuelas = 0;
            casasRegistradas[6].lugarCasa.centrosComerciales = 1;
            casasRegistradas[6].lugarCasa.transporte = 2;
            casasRegistradas[6].modelo = "Departamento";
            casasRegistradas[6].cuartos = 1;
            casasRegistradas[6].banos = 1;
            casasRegistradas[6].parqueaderos = "No";
            casasRegistradas[6].espacioVerdes = "No";
            casasRegistradas[6].precioCasa = 955000;
            //8
            casasRegistradas[7].lugarCasa.sector = "Norte";
            casasRegistradas[7].lugarCasa.parques = 1;
            casasRegistradas[7].lugarCasa.escuelas = 1;
            casasRegistradas[7].lugarCasa.centrosComerciales = 1;
            casasRegistradas[7].lugarCasa.transporte = 2;
            casasRegistradas[7].modelo = "Vivienda";
            casasRegistradas[7].cuartos = 2;
            casasRegistradas[7].banos = 2;
            casasRegistradas[7].parqueaderos = "Si";
            casasRegistradas[7].espacioVerdes = "Si";
            casasRegistradas[7].precioCasa = 500000;
            //9
            casasRegistradas[8].lugarCasa.sector = "Norte";
            casasRegistradas[8].lugarCasa.parques = 2;
            casasRegistradas[8].lugarCasa.escuelas = 2;
            casasRegistradas[8].lugarCasa.centrosComerciales = 2;
            casasRegistradas[8].lugarCasa.transporte = 1;
            casasRegistradas[8].modelo = "Vivienda";
            casasRegistradas[8].cuartos = 5;
            casasRegistradas[8].banos = 3;
            casasRegistradas[8].parqueaderos = "No";
            casasRegistradas[8].espacioVerdes = "Si";
            casasRegistradas[8].precioCasa = 450000;
            //10
            casasRegistradas[9].lugarCasa.sector = "Norte";
            casasRegistradas[9].lugarCasa.parques = 0;
            casasRegistradas[9].lugarCasa.escuelas = 0;
            casasRegistradas[9].lugarCasa.centrosComerciales = 0;
            casasRegistradas[9].lugarCasa.transporte = 0;
            casasRegistradas[9].modelo = "Departamento";
            casasRegistradas[9].cuartos = 1;
            casasRegistradas[9].banos = 1;
            casasRegistradas[9].parqueaderos = "Si";
            casasRegistradas[9].espacioVerdes = "No";
            casasRegistradas[9].precioCasa = 87000;
            //FIN DE CASAS REGISTRADAS
            
            Persona persona1 = new Persona(); //constructor de una nueva persona
            Casa casaDeseada = new Casa(); //constructor de la casa deseada

            // CAMBIAR LA VARIABLE DE CENTROS COMERCIALES
            persona1.nombre = txtNombre.Text; //obtener el texto de un text box
            persona1.presupuesto = Convert.ToDouble(txtPresupuesto.Text, System.Globalization.CultureInfo.GetCultureInfo("es-ES")); //para convertir a double
            casaDeseada.cuartos = int.Parse(txtCuartos.Text);
            casaDeseada.lugarCasa.parques = int.Parse(txtParques.Text);
            casaDeseada.lugarCasa.escuelas = int.Parse(txtEscuelas.Text);
            casaDeseada.banos = int.Parse(txtBanos.Text);
            casaDeseada.lugarCasa.centrosComerciales = int.Parse(txtCeCo.Text);
            casaDeseada.lugarCasa.transporte = int.Parse(txtTransporte.Text);
            //ASIGNACION DE RADIO BUTTONS
            if (rbCentro.Checked)
            {
                casaDeseada.lugarCasa.sector = "Centro";
            }
            else if (rbSur.Checked)
            {
                casaDeseada.lugarCasa.sector = "Sur";
            }
            else if (rbNorte.Checked)
            {
                casaDeseada.lugarCasa.sector = "Norte";
            }
            if (rbSiP.Checked)
            {
                casaDeseada.parqueaderos = "Si";
            }
            else if (rbNoP.Checked)
            {
                casaDeseada.parqueaderos = "No";
            }
            if (rbSiE.Checked)
            {
                casaDeseada.espacioVerdes = "Si";
            }

            else if (rbNoE.Checked)
            {
                casaDeseada.espacioVerdes = "No";

            }
            if (rbVivienda.Checked)
            {
                casaDeseada.modelo = "Vivienda";
            }
            else if (rbCondominio.Checked)
            {
                casaDeseada.modelo = "Condominio";
            }
            else if (rbDepartamento.Checked)
            {
                casaDeseada.modelo = "Departamento";
            }
            txaBusqueda.Clear();

        }
    }
}
