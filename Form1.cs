using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasDeCasaUIO
{    //DECLARACION DE ESTRUCTURAS
    //estructura persona
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
    public partial class VentasDeCasasUIO : Form
    {
        //DECLARACION DE VARIABLES DE ALCANCE GLOBAL
        int n = 30;
        bool encontrado;
        int busqueda;
        double subTotal;
        double Total;
        public VentasDeCasasUIO()
        {
            InitializeComponent();
            //Para al empezar ocultar el boton de cuotas y el label de cuotas
            txtCuotas.Hide();
            lbCuotas.Hide();
            //ocultamiento de btn confirmar hasta que cumpla con especificaciones como la busqueda
            btnConfirmar.Hide();
            rbCredito.Enabled = false;
            rbEfectivo.Enabled = false;
            btnComprar.Enabled = false;
        }
        //llamada a la clase validadora de numeros y letras para su uso 
        ValidadorDeNumerosLetras validar = new ValidadorDeNumerosLetras(); //constructor del objeto validor
      //clase para buscar la casa deseada en base a las casas registradas
        public void busquedaCasa(Casa[] casa2, int tamanio, Casa casaDeseada, Persona p1)
        {
            for (int i = 0; i < tamanio; i++)
            {
                if (casa2[i].lugarCasa.sector.Equals(casaDeseada.lugarCasa.sector))
                {
                    if (casa2[i].lugarCasa.parques == casaDeseada.lugarCasa.parques)
                    {
                        if (casa2[i].lugarCasa.escuelas == casaDeseada.lugarCasa.escuelas)
                        {
                            if (casa2[i].lugarCasa.centrosComerciales == casaDeseada.lugarCasa.centrosComerciales)
                            {
                                if (casa2[i].lugarCasa.transporte == casaDeseada.lugarCasa.transporte)
                                {
                                    if (casa2[i].modelo.Equals(casaDeseada.modelo))
                                    {
                                        if (casa2[i].cuartos == casaDeseada.cuartos)
                                        {
                                            if (casa2[i].banos == casaDeseada.banos)
                                            {
                                                if (casa2[i].parqueaderos.Equals(casaDeseada.parqueaderos))
                                                {
                                                    if (casa2[i].espacioVerdes.Equals(casaDeseada.espacioVerdes))
                                                    {
                                                        if (casa2[i].precioCasa <= p1.presupuesto || casa2[i].precioCasa >= p1.presupuesto)
                                                        {
                                                            busqueda = i;
                                                            encontrado = true;
                                                            if (encontrado)
                                                            { //mostrar casa y habilitar los botones y radio de comprar
                                                                mostrarCasa(casa2, p1, busqueda);
                                                                rbEfectivo.Enabled = true;
                                                                rbCredito.Enabled = true;
                                                                btnComprar.Enabled = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //clase para mostrar la casa encontrada si la busqueda es exitosa
        public void mostrarCasa(Casa[] casa2, Persona p1, int aux)
        { //MOSTRAR COMENTARIO 
            txaBusqueda.Text = p1.nombre + ", hemos encontrado la casa de tus sueños:" + "\r\n"
            + "1  " + casa2[aux].modelo + "\r\n" +
            "Ubicada en: " + casa2[aux].lugarCasa.sector + " de Quito" + "\r\n" +
            "Con " + casa2[aux].cuartos + " cuartos y " + casa2[aux].banos + "  baños " + "\r\n" +
            "Parqueadero : " + casa2[aux].parqueaderos + "       Espacios Verdes: " + casa2[aux].espacioVerdes + "\r\n"
            + "Y esta cerca de: " + "\r\n" + casa2[aux].lugarCasa.parques + " parques, " +
            +casa2[aux].lugarCasa.escuelas + " escuelas, y " + casa2[aux].lugarCasa.transporte +
            " sitios de transporte " + "\r\n" + "A un precio de:   " + casa2[aux].precioCasa + "$ ";
        }
        //clase para calcular el credito 
        public void CalcularCredito(Persona p1, int aux, Casa[] casas)
        {
            Credito credito = new Credito();//Constructor de un nuevo credito 
            credito.cuotasMaxima = 25;
            credito.presupuestoInicial = p1.presupuesto;
            credito.numeroCuotas = int.Parse(txtCuotas.Text);
            if (credito.numeroCuotas <= credito.cuotasMaxima)
            {
                if (credito.presupuestoInicial >= casas[aux].precioCasa)
                {
                    subTotal = (casas[aux].precioCasa / credito.numeroCuotas);
                    Total = subTotal;
                    txaRecibo.Text = p1.nombre + ", tu credito se ha realizado sastifactoriamente y" + "\r\n"
                        + "tendras que pagar " + credito.numeroCuotas + " cuotas de  " + Math.Round(Total, 2) + "$";
                }
                else
                {
                    if (credito.presupuestoInicial < casas[aux].precioCasa)
                    {
                        subTotal = casas[aux].precioCasa - credito.presupuestoInicial;
                        Total = subTotal / credito.numeroCuotas;
                        txaRecibo.Text = p1.nombre + ", tu credito se ha realizado sastifactoriamente y" + "\r\n"
                            + "tendras que pagar una cuota inicial de " + credito.presupuestoInicial + "$ y " + credito.numeroCuotas + " cuotas de  " + Math.Round(Total, 2) + "$";
                    }
                }
            }
            else
            {
                txaRecibo.Text = "Lo sentimos, " + p1.nombre + ", tu credito no se ha realizado sastifactoriamente ya "
                    + "que nuestro sistema solo acepta un maximo de " + credito.cuotasMaxima + " cuotas "
                    + "\r\n" + "   INTENTELO DE NUEVO ";
            }
        }
        //clase para la eleccion de forma de pago 
        public void FormaDePago(Casa[] casas, int aux, Persona p1)
        {
            if (rbEfectivo.Checked)
            {
                txaRecibo.Text = "Nombre: " + p1.nombre + "\r\n" + "Total a pagar: " + casas[aux].precioCasa;
            }
            else if (rbCredito.Checked)
            {
                CalcularCredito(p1, aux, casas);
            }
            btnConfirmar.Show(); ////mostrando el boton confirmar 
        }
        //instrucciones para el boton confirmar 
        private void btnConfirmar_Click(object sender, EventArgs e)
        {   //PARA ABRIR LA NUEVA VENTANA DE CONFIRMAR
            Agradecimiento agradecimiento = new Agradecimiento();
            agradecimiento.Show();
            this.Hide();
        }
        //instrucciones para el boton buscar
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
            casasRegistradas[0].precioCasa = 70000;
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
            casasRegistradas[1].precioCasa = 45000;
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
            casasRegistradas[2].precioCasa = 75000;
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
            casasRegistradas[3].precioCasa = 60000;
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
            casasRegistradas[5].precioCasa = 40000;
            //7
            casasRegistradas[6].lugarCasa.sector = "Norte";
            casasRegistradas[6].lugarCasa.parques = 0;
            casasRegistradas[6].lugarCasa.escuelas = 1;
            casasRegistradas[6].lugarCasa.centrosComerciales = 1;
            casasRegistradas[6].lugarCasa.transporte = 2;
            casasRegistradas[6].modelo = "Departamento";
            casasRegistradas[6].cuartos = 1;
            casasRegistradas[6].banos = 1;
            casasRegistradas[6].parqueaderos = "No";
            casasRegistradas[6].espacioVerdes = "No";
            casasRegistradas[6].precioCasa = 80000;
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
            casasRegistradas[7].precioCasa = 90000;
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
            casasRegistradas[8].precioCasa = 70000;
            //10
            casasRegistradas[9].lugarCasa.sector = "Norte";
            casasRegistradas[9].lugarCasa.parques = 0;
            casasRegistradas[9].lugarCasa.escuelas = 0;
            casasRegistradas[9].lugarCasa.centrosComerciales = 0;
            casasRegistradas[9].lugarCasa.transporte = 1;
            casasRegistradas[9].modelo = "Departamento";
            casasRegistradas[9].cuartos = 1;
            casasRegistradas[9].banos = 1;
            casasRegistradas[9].parqueaderos = "Si";
            casasRegistradas[9].espacioVerdes = "No";
            casasRegistradas[9].precioCasa = 80000;
            //Javier
            //casas Centro 
            //Javier 
            //casas Centro  
            //11 
            casasRegistradas[10].lugarCasa.sector = "Centro";
            casasRegistradas[10].lugarCasa.parques = 2;
            casasRegistradas[10].lugarCasa.escuelas = 2;
            casasRegistradas[10].lugarCasa.centrosComerciales = 3;
            casasRegistradas[10].lugarCasa.transporte = 2;
            casasRegistradas[10].modelo = "Vivienda";
            casasRegistradas[10].cuartos = 3;
            casasRegistradas[10].banos = 2;
            casasRegistradas[10].parqueaderos = "Si";
            casasRegistradas[10].espacioVerdes = "Si";
            casasRegistradas[10].precioCasa = 76000;
            //12 
            casasRegistradas[11].lugarCasa.sector = "Centro";
            casasRegistradas[11].lugarCasa.parques = 4;
            casasRegistradas[11].lugarCasa.escuelas = 2;
            casasRegistradas[11].lugarCasa.centrosComerciales = 3;
            casasRegistradas[11].lugarCasa.transporte = 3;
            casasRegistradas[11].modelo = "Departamento";
            casasRegistradas[11].cuartos = 3;
            casasRegistradas[11].banos = 1;
            casasRegistradas[11].parqueaderos = "No";
            casasRegistradas[11].espacioVerdes = "No";
            casasRegistradas[11].precioCasa = 75000;
            //13 
            casasRegistradas[12].lugarCasa.sector = "Centro";
            casasRegistradas[12].lugarCasa.parques = 4;
            casasRegistradas[12].lugarCasa.escuelas = 4;
            casasRegistradas[12].lugarCasa.centrosComerciales = 4;
            casasRegistradas[12].lugarCasa.transporte = 3;
            casasRegistradas[12].modelo = "Condominio";
            casasRegistradas[12].cuartos = 3;
            casasRegistradas[12].banos = 2;
            casasRegistradas[12].parqueaderos = "Si";
            casasRegistradas[12].espacioVerdes = "No";
            casasRegistradas[12].precioCasa = 50000;
            //14 
            casasRegistradas[13].lugarCasa.sector = "Centro";
            casasRegistradas[13].lugarCasa.parques = 4;
            casasRegistradas[13].lugarCasa.escuelas = 5;
            casasRegistradas[13].lugarCasa.centrosComerciales = 4;
            casasRegistradas[13].lugarCasa.transporte = 4;
            casasRegistradas[13].modelo = "Condominio";
            casasRegistradas[13].cuartos = 3;
            casasRegistradas[13].banos = 2;
            casasRegistradas[13].parqueaderos = "Si";
            casasRegistradas[13].espacioVerdes = "No";
            casasRegistradas[13].precioCasa = 40000;
            //15 
            casasRegistradas[14].lugarCasa.sector = "Centro";
            casasRegistradas[14].lugarCasa.parques = 4;
            casasRegistradas[14].lugarCasa.escuelas = 4;
            casasRegistradas[14].lugarCasa.centrosComerciales = 4;
            casasRegistradas[14].lugarCasa.transporte = 3;
            casasRegistradas[14].modelo = "Departamento";
            casasRegistradas[14].cuartos = 2;
            casasRegistradas[14].banos = 1;
            casasRegistradas[14].parqueaderos = "Si";
            casasRegistradas[14].espacioVerdes = "Si";
            casasRegistradas[14].precioCasa = 50000;
            //16 
            casasRegistradas[15].lugarCasa.sector = "Centro";
            casasRegistradas[15].lugarCasa.parques = 4;
            casasRegistradas[15].lugarCasa.escuelas = 4;
            casasRegistradas[15].lugarCasa.centrosComerciales = 4;
            casasRegistradas[15].lugarCasa.transporte = 2;
            casasRegistradas[15].modelo = "Vivienda";
            casasRegistradas[15].cuartos = 3;
            casasRegistradas[15].banos = 2;
            casasRegistradas[15].parqueaderos = "Si";
            casasRegistradas[15].espacioVerdes = "No";
            casasRegistradas[15].precioCasa = 70000;
            //17 
            casasRegistradas[16].lugarCasa.sector = "Centro";
            casasRegistradas[16].lugarCasa.parques = 4;
            casasRegistradas[16].lugarCasa.escuelas = 4;
            casasRegistradas[16].lugarCasa.centrosComerciales = 4;
            casasRegistradas[16].lugarCasa.transporte = 2;
            casasRegistradas[16].modelo = "Condominio";
            casasRegistradas[16].cuartos = 3;
            casasRegistradas[16].banos = 2;
            casasRegistradas[16].parqueaderos = "No";
            casasRegistradas[16].espacioVerdes = "No";
            casasRegistradas[16].precioCasa = 45000;
            //18 
            casasRegistradas[17].lugarCasa.sector = "Centro";
            casasRegistradas[17].lugarCasa.parques = 2;
            casasRegistradas[17].lugarCasa.escuelas = 3;
            casasRegistradas[17].lugarCasa.centrosComerciales = 2;
            casasRegistradas[17].lugarCasa.transporte = 3;
            casasRegistradas[17].modelo = "Condominio";
            casasRegistradas[17].cuartos = 3;
            casasRegistradas[17].banos = 2;
            casasRegistradas[17].parqueaderos = "Si";
            casasRegistradas[17].espacioVerdes = "No";
            casasRegistradas[17].precioCasa = 53000;
            //19 
            casasRegistradas[18].lugarCasa.sector = "Centro";
            casasRegistradas[18].lugarCasa.parques = 1;
            casasRegistradas[18].lugarCasa.escuelas = 2;
            casasRegistradas[18].lugarCasa.centrosComerciales = 4;
            casasRegistradas[18].lugarCasa.transporte = 4;
            casasRegistradas[18].modelo = "Condominio";
            casasRegistradas[18].cuartos = 2;
            casasRegistradas[18].banos = 2;
            casasRegistradas[18].parqueaderos = "Si";
            casasRegistradas[18].espacioVerdes = "Si";
            casasRegistradas[18].precioCasa = 60000;
            //20 
            casasRegistradas[19].lugarCasa.sector = "Centro";
            casasRegistradas[19].lugarCasa.parques = 1;
            casasRegistradas[19].lugarCasa.escuelas = 3;
            casasRegistradas[19].lugarCasa.centrosComerciales = 1;
            casasRegistradas[19].lugarCasa.transporte = 2;
            casasRegistradas[19].modelo = "Condominio";
            casasRegistradas[19].cuartos = 1;
            casasRegistradas[19].banos = 1;
            casasRegistradas[19].parqueaderos = "Si";
            casasRegistradas[19].espacioVerdes = "No";
            casasRegistradas[19].precioCasa = 55000;

            //casas al Sur
            //21 
            casasRegistradas[20].lugarCasa.sector = "Sur";
            casasRegistradas[20].lugarCasa.parques = 2;
            casasRegistradas[20].lugarCasa.escuelas = 3;
            casasRegistradas[20].lugarCasa.centrosComerciales = 2;
            casasRegistradas[20].lugarCasa.transporte = 3;
            casasRegistradas[20].modelo = "Departamento";
            casasRegistradas[20].cuartos = 2;
            casasRegistradas[20].banos = 1;
            casasRegistradas[20].parqueaderos = "Si";
            casasRegistradas[20].espacioVerdes = "No";
            casasRegistradas[20].precioCasa = 45000;
            //22 
            casasRegistradas[21].lugarCasa.sector = "Sur";
            casasRegistradas[21].lugarCasa.parques = 1;
            casasRegistradas[21].lugarCasa.escuelas = 2;
            casasRegistradas[21].lugarCasa.centrosComerciales = 1;
            casasRegistradas[21].lugarCasa.transporte = 4;
            casasRegistradas[21].modelo = "Vivienda";
            casasRegistradas[21].cuartos = 3;
            casasRegistradas[21].banos = 2;
            casasRegistradas[21].parqueaderos = "No";
            casasRegistradas[21].espacioVerdes = "Si";
            casasRegistradas[21].precioCasa = 25000;
            //23 
            casasRegistradas[22].lugarCasa.sector = "Sur";
            casasRegistradas[22].lugarCasa.parques = 3;
            casasRegistradas[22].lugarCasa.escuelas = 2;
            casasRegistradas[22].lugarCasa.centrosComerciales = 1;
            casasRegistradas[22].lugarCasa.transporte = 2;
            casasRegistradas[22].modelo = "Condominio";
            casasRegistradas[22].cuartos = 2;
            casasRegistradas[22].banos = 3;
            casasRegistradas[22].parqueaderos = "Si";
            casasRegistradas[22].espacioVerdes = "Si";
            casasRegistradas[22].precioCasa = 45000;
            //24 
            casasRegistradas[23].lugarCasa.sector = "Sur";
            casasRegistradas[23].lugarCasa.parques = 2;
            casasRegistradas[23].lugarCasa.escuelas = 1;
            casasRegistradas[23].lugarCasa.centrosComerciales = 2;
            casasRegistradas[23].lugarCasa.transporte = 3;
            casasRegistradas[23].modelo = "Departamento";
            casasRegistradas[23].cuartos = 1;
            casasRegistradas[23].banos = 1;
            casasRegistradas[23].parqueaderos = "No";
            casasRegistradas[23].espacioVerdes = "No";
            casasRegistradas[23].precioCasa = 55000;
            //25 
            casasRegistradas[24].lugarCasa.sector = "Sur";
            casasRegistradas[24].lugarCasa.parques = 3;
            casasRegistradas[24].lugarCasa.escuelas = 1;
            casasRegistradas[24].lugarCasa.centrosComerciales = 2;
            casasRegistradas[24].lugarCasa.transporte = 2;
            casasRegistradas[24].modelo = "Vivienda";
            casasRegistradas[24].cuartos = 2;
            casasRegistradas[24].banos = 2;
            casasRegistradas[24].parqueaderos = "Si";
            casasRegistradas[24].espacioVerdes = "No";
            casasRegistradas[24].precioCasa = 35000;
            //26 
            casasRegistradas[25].lugarCasa.sector = "Sur";
            casasRegistradas[25].lugarCasa.parques = 1;
            casasRegistradas[25].lugarCasa.escuelas = 1;
            casasRegistradas[25].lugarCasa.centrosComerciales = 3;
            casasRegistradas[25].lugarCasa.transporte = 2;
            casasRegistradas[25].modelo = "Vivienda";
            casasRegistradas[25].cuartos = 2;
            casasRegistradas[25].banos = 2;
            casasRegistradas[25].parqueaderos = "No";
            casasRegistradas[25].espacioVerdes = "Si";
            casasRegistradas[25].precioCasa = 38000;
            //27 
            casasRegistradas[26].lugarCasa.sector = "Sur";
            casasRegistradas[26].lugarCasa.parques = 1;
            casasRegistradas[26].lugarCasa.escuelas = 3;
            casasRegistradas[26].lugarCasa.centrosComerciales = 1;
            casasRegistradas[26].lugarCasa.transporte = 2;
            casasRegistradas[26].modelo = "Condominio";
            casasRegistradas[26].cuartos = 1;
            casasRegistradas[26].banos = 1;
            casasRegistradas[26].parqueaderos = "No";
            casasRegistradas[26].espacioVerdes = "No";
            casasRegistradas[26].precioCasa = 59000;
            //28 
            casasRegistradas[27].lugarCasa.sector = "Sur";
            casasRegistradas[27].lugarCasa.parques = 1;
            casasRegistradas[27].lugarCasa.escuelas = 2;
            casasRegistradas[27].lugarCasa.centrosComerciales = 1;
            casasRegistradas[27].lugarCasa.transporte = 1;
            casasRegistradas[27].modelo = "Condominio";
            casasRegistradas[27].cuartos = 2;
            casasRegistradas[27].banos = 2;
            casasRegistradas[27].parqueaderos = "Si";
            casasRegistradas[27].espacioVerdes = "No";
            casasRegistradas[27].precioCasa = 60000;
            //29 
            casasRegistradas[28].lugarCasa.sector = "Sur";
            casasRegistradas[28].lugarCasa.parques = 3;
            casasRegistradas[28].lugarCasa.escuelas = 5;
            casasRegistradas[28].lugarCasa.centrosComerciales = 2;
            casasRegistradas[28].lugarCasa.transporte = 3;
            casasRegistradas[28].modelo = "Departamento";
            casasRegistradas[28].cuartos = 3;
            casasRegistradas[28].banos = 2;
            casasRegistradas[28].parqueaderos = "No";
            casasRegistradas[28].espacioVerdes = "No";
            casasRegistradas[28].precioCasa = 70000;
            //30 
            casasRegistradas[29].lugarCasa.sector = "Sur";
            casasRegistradas[29].lugarCasa.parques = 2;
            casasRegistradas[29].lugarCasa.escuelas = 4;
            casasRegistradas[29].lugarCasa.centrosComerciales = 2;
            casasRegistradas[29].lugarCasa.transporte = 1;
            casasRegistradas[29].modelo = "Vivienda";
            casasRegistradas[29].cuartos = 3;
            casasRegistradas[29].banos = 3;
            casasRegistradas[29].parqueaderos = "Si";
            casasRegistradas[29].espacioVerdes = "Si";
            casasRegistradas[29].precioCasa = 39000;
            //FIN DE CASAS REGISTRADAS
            try
            {
                Persona persona1 = new Persona(); //creamos el objeto de una nueva persona
                Casa casaDeseada = new Casa(); //creamos el objeto de la casa deseada
                //Obtencion y asginacion de variables
                if (txtNombre.Text.Length != 0)
                {
                    persona1.nombre = txtNombre.Text;
                    persona1.presupuesto = Convert.ToDouble(txtPresupuesto.Text, System.Globalization.CultureInfo.GetCultureInfo("es-ES")); //para convertir a double
                    casaDeseada.cuartos = int.Parse(txtCuartos.Text);
                    casaDeseada.lugarCasa.parques = int.Parse(txtParques.Text);
                    casaDeseada.lugarCasa.escuelas = int.Parse(txtEscuelas.Text);
                    casaDeseada.banos = int.Parse(txtBanos.Text);
                    casaDeseada.lugarCasa.centrosComerciales = int.Parse(txtCeCo.Text);
                    casaDeseada.lugarCasa.transporte = int.Parse(txtTransporte.Text);
                    //ASIGNACION DE RADIO BUTTONS
                    if ((rbCentro.Checked || rbSur.Checked || rbNorte.Checked) && (rbSiP.Checked || rbNoP.Checked) && (rbSiE.Checked || rbNoE.Checked) && (rbVivienda.Checked || rbCondominio.Checked || rbDepartamento.Checked))
                    {
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
                        //llamada a la funcion busqueda
                        busquedaCasa(casasRegistradas, n, casaDeseada, persona1);
                        //instruccion por si la busqueda no fue exitosa
                        if (txaBusqueda.Text.Length == 0)
                        {
                            txaBusqueda.Text = "                    " + persona1.nombre + ", lo sentimos no contamos con una casa con esas caracteristicas. "
                                + "\r\n" + "                            Cambia algunas caracteristicas o presiona en \"Intentelo de nuevo\".";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llena todos los datos para mejores resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llena todos los datos para mejores resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Llena todos los datos para mejores resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //instruciones para el radio boton credito. 
        private void rbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            //para mostar el text de cuotas cuando este señanalado cuotas
            if (rbCredito.Checked)
            {
                txtCuotas.Show();
                lbCuotas.Show();
            }
            else
            {
                txtCuotas.Hide();
                lbCuotas.Hide();
            }
        }
        //instrucciones para el boton comprar
        private void btnCompar_Click(object sender, EventArgs e)
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
            casasRegistradas[0].precioCasa = 70000;
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
            casasRegistradas[1].precioCasa = 45000;
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
            casasRegistradas[2].precioCasa = 75000;
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
            casasRegistradas[3].precioCasa = 60000;
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
            casasRegistradas[5].precioCasa = 40000;
            //7
            casasRegistradas[6].lugarCasa.sector = "Norte";
            casasRegistradas[6].lugarCasa.parques = 0;
            casasRegistradas[6].lugarCasa.escuelas = 1;
            casasRegistradas[6].lugarCasa.centrosComerciales = 1;
            casasRegistradas[6].lugarCasa.transporte = 2;
            casasRegistradas[6].modelo = "Departamento";
            casasRegistradas[6].cuartos = 1;
            casasRegistradas[6].banos = 1;
            casasRegistradas[6].parqueaderos = "No";
            casasRegistradas[6].espacioVerdes = "No";
            casasRegistradas[6].precioCasa = 80000;
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
            casasRegistradas[7].precioCasa = 90000;
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
            casasRegistradas[8].precioCasa = 70000;
            //10
            casasRegistradas[9].lugarCasa.sector = "Norte";
            casasRegistradas[9].lugarCasa.parques = 0;
            casasRegistradas[9].lugarCasa.escuelas = 0;
            casasRegistradas[9].lugarCasa.centrosComerciales = 0;
            casasRegistradas[9].lugarCasa.transporte = 1;
            casasRegistradas[9].modelo = "Departamento";
            casasRegistradas[9].cuartos = 1;
            casasRegistradas[9].banos = 1;
            casasRegistradas[9].parqueaderos = "Si";
            casasRegistradas[9].espacioVerdes = "No";
            casasRegistradas[9].precioCasa = 80000;
            //Javier
            //casas Centro 
            //11
            //Javier 
            //casas Centro  
            //11 
            casasRegistradas[10].lugarCasa.sector = "Centro";
            casasRegistradas[10].lugarCasa.parques = 2;
            casasRegistradas[10].lugarCasa.escuelas = 2;
            casasRegistradas[10].lugarCasa.centrosComerciales = 3;
            casasRegistradas[10].lugarCasa.transporte = 2;
            casasRegistradas[10].modelo = "Vivienda";
            casasRegistradas[10].cuartos = 3;
            casasRegistradas[10].banos = 2;
            casasRegistradas[10].parqueaderos = "Si";
            casasRegistradas[10].espacioVerdes = "Si";
            casasRegistradas[10].precioCasa = 76000;
            //12 
            casasRegistradas[11].lugarCasa.sector = "Centro";
            casasRegistradas[11].lugarCasa.parques = 4;
            casasRegistradas[11].lugarCasa.escuelas = 2;
            casasRegistradas[11].lugarCasa.centrosComerciales = 3;
            casasRegistradas[11].lugarCasa.transporte = 3;
            casasRegistradas[11].modelo = "Departamento";
            casasRegistradas[11].cuartos = 3;
            casasRegistradas[11].banos = 1;
            casasRegistradas[11].parqueaderos = "No";
            casasRegistradas[11].espacioVerdes = "No";
            casasRegistradas[11].precioCasa = 75000;
            //13 
            casasRegistradas[12].lugarCasa.sector = "Centro";
            casasRegistradas[12].lugarCasa.parques = 4;
            casasRegistradas[12].lugarCasa.escuelas = 4;
            casasRegistradas[12].lugarCasa.centrosComerciales = 4;
            casasRegistradas[12].lugarCasa.transporte = 3;
            casasRegistradas[12].modelo = "Condominio";
            casasRegistradas[12].cuartos = 3;
            casasRegistradas[12].banos = 2;
            casasRegistradas[12].parqueaderos = "Si";
            casasRegistradas[12].espacioVerdes = "No";
            casasRegistradas[12].precioCasa = 50000;
            //14 
            casasRegistradas[13].lugarCasa.sector = "Centro";
            casasRegistradas[13].lugarCasa.parques = 4;
            casasRegistradas[13].lugarCasa.escuelas = 5;
            casasRegistradas[13].lugarCasa.centrosComerciales = 4;
            casasRegistradas[13].lugarCasa.transporte = 4;
            casasRegistradas[13].modelo = "Condominio";
            casasRegistradas[13].cuartos = 3;
            casasRegistradas[13].banos = 2;
            casasRegistradas[13].parqueaderos = "Si";
            casasRegistradas[13].espacioVerdes = "No";
            casasRegistradas[13].precioCasa = 40000;
            //15 
            casasRegistradas[14].lugarCasa.sector = "Centro";
            casasRegistradas[14].lugarCasa.parques = 4;
            casasRegistradas[14].lugarCasa.escuelas = 4;
            casasRegistradas[14].lugarCasa.centrosComerciales = 4;
            casasRegistradas[14].lugarCasa.transporte = 3;
            casasRegistradas[14].modelo = "Departamento";
            casasRegistradas[14].cuartos = 2;
            casasRegistradas[14].banos = 1;
            casasRegistradas[14].parqueaderos = "Si";
            casasRegistradas[14].espacioVerdes = "Si";
            casasRegistradas[14].precioCasa = 50000;
            //16 
            casasRegistradas[15].lugarCasa.sector = "Centro";
            casasRegistradas[15].lugarCasa.parques = 4;
            casasRegistradas[15].lugarCasa.escuelas = 4;
            casasRegistradas[15].lugarCasa.centrosComerciales = 4;
            casasRegistradas[15].lugarCasa.transporte = 2;
            casasRegistradas[15].modelo = "Vivienda";
            casasRegistradas[15].cuartos = 3;
            casasRegistradas[15].banos = 2;
            casasRegistradas[15].parqueaderos = "Si";
            casasRegistradas[15].espacioVerdes = "No";
            casasRegistradas[15].precioCasa = 70000;
            //17 
            casasRegistradas[16].lugarCasa.sector = "Centro";
            casasRegistradas[16].lugarCasa.parques = 4;
            casasRegistradas[16].lugarCasa.escuelas = 4;
            casasRegistradas[16].lugarCasa.centrosComerciales = 4;
            casasRegistradas[16].lugarCasa.transporte = 2;
            casasRegistradas[16].modelo = "Condominio";
            casasRegistradas[16].cuartos = 3;
            casasRegistradas[16].banos = 2;
            casasRegistradas[16].parqueaderos = "No";
            casasRegistradas[16].espacioVerdes = "No";
            casasRegistradas[16].precioCasa = 45000;
            //18 
            casasRegistradas[17].lugarCasa.sector = "Centro";
            casasRegistradas[17].lugarCasa.parques = 2;
            casasRegistradas[17].lugarCasa.escuelas = 3;
            casasRegistradas[17].lugarCasa.centrosComerciales = 2;
            casasRegistradas[17].lugarCasa.transporte = 3;
            casasRegistradas[17].modelo = "Condominio";
            casasRegistradas[17].cuartos = 3;
            casasRegistradas[17].banos = 2;
            casasRegistradas[17].parqueaderos = "Si";
            casasRegistradas[17].espacioVerdes = "No";
            casasRegistradas[17].precioCasa = 53000;
            //19 
            casasRegistradas[18].lugarCasa.sector = "Centro";
            casasRegistradas[18].lugarCasa.parques = 1;
            casasRegistradas[18].lugarCasa.escuelas = 2;
            casasRegistradas[18].lugarCasa.centrosComerciales = 4;
            casasRegistradas[18].lugarCasa.transporte = 4;
            casasRegistradas[18].modelo = "Condominio";
            casasRegistradas[18].cuartos = 2;
            casasRegistradas[18].banos = 2;
            casasRegistradas[18].parqueaderos = "Si";
            casasRegistradas[18].espacioVerdes = "Si";
            casasRegistradas[18].precioCasa = 60000;
            //20 
            casasRegistradas[19].lugarCasa.sector = "Centro";
            casasRegistradas[19].lugarCasa.parques = 1;
            casasRegistradas[19].lugarCasa.escuelas = 3;
            casasRegistradas[19].lugarCasa.centrosComerciales = 1;
            casasRegistradas[19].lugarCasa.transporte = 2;
            casasRegistradas[19].modelo = "Condominio";
            casasRegistradas[19].cuartos = 1;
            casasRegistradas[19].banos = 1;
            casasRegistradas[19].parqueaderos = "Si";
            casasRegistradas[19].espacioVerdes = "No";
            casasRegistradas[19].precioCasa = 55000;

            //casas al Sur
            //21 
            casasRegistradas[20].lugarCasa.sector = "Sur";
            casasRegistradas[20].lugarCasa.parques = 2;
            casasRegistradas[20].lugarCasa.escuelas = 3;
            casasRegistradas[20].lugarCasa.centrosComerciales = 2;
            casasRegistradas[20].lugarCasa.transporte = 3;
            casasRegistradas[20].modelo = "Departamento";
            casasRegistradas[20].cuartos = 2;
            casasRegistradas[20].banos = 1;
            casasRegistradas[20].parqueaderos = "Si";
            casasRegistradas[20].espacioVerdes = "No";
            casasRegistradas[20].precioCasa = 45000;
            //22 
            casasRegistradas[21].lugarCasa.sector = "Sur";
            casasRegistradas[21].lugarCasa.parques = 1;
            casasRegistradas[21].lugarCasa.escuelas = 2;
            casasRegistradas[21].lugarCasa.centrosComerciales = 1;
            casasRegistradas[21].lugarCasa.transporte = 4;
            casasRegistradas[21].modelo = "Vivienda";
            casasRegistradas[21].cuartos = 3;
            casasRegistradas[21].banos = 2;
            casasRegistradas[21].parqueaderos = "No";
            casasRegistradas[21].espacioVerdes = "Si";
            casasRegistradas[21].precioCasa = 25000;
            //23 
            casasRegistradas[22].lugarCasa.sector = "Sur";
            casasRegistradas[22].lugarCasa.parques = 3;
            casasRegistradas[22].lugarCasa.escuelas = 2;
            casasRegistradas[22].lugarCasa.centrosComerciales = 1;
            casasRegistradas[22].lugarCasa.transporte = 2;
            casasRegistradas[22].modelo = "Condominio";
            casasRegistradas[22].cuartos = 2;
            casasRegistradas[22].banos = 3;
            casasRegistradas[22].parqueaderos = "Si";
            casasRegistradas[22].espacioVerdes = "Si";
            casasRegistradas[22].precioCasa = 45000;
            //24 
            casasRegistradas[23].lugarCasa.sector = "Sur";
            casasRegistradas[23].lugarCasa.parques = 2;
            casasRegistradas[23].lugarCasa.escuelas = 1;
            casasRegistradas[23].lugarCasa.centrosComerciales = 2;
            casasRegistradas[23].lugarCasa.transporte = 3;
            casasRegistradas[23].modelo = "Departamento";
            casasRegistradas[23].cuartos = 1;
            casasRegistradas[23].banos = 1;
            casasRegistradas[23].parqueaderos = "No";
            casasRegistradas[23].espacioVerdes = "No";
            casasRegistradas[23].precioCasa = 55000;
            //25 
            casasRegistradas[24].lugarCasa.sector = "Sur";
            casasRegistradas[24].lugarCasa.parques = 3;
            casasRegistradas[24].lugarCasa.escuelas = 1;
            casasRegistradas[24].lugarCasa.centrosComerciales = 2;
            casasRegistradas[24].lugarCasa.transporte = 2;
            casasRegistradas[24].modelo = "Vivienda";
            casasRegistradas[24].cuartos = 2;
            casasRegistradas[24].banos = 2;
            casasRegistradas[24].parqueaderos = "Si";
            casasRegistradas[24].espacioVerdes = "No";
            casasRegistradas[24].precioCasa = 35000;
            //26 
            casasRegistradas[25].lugarCasa.sector = "Sur";
            casasRegistradas[25].lugarCasa.parques = 1;
            casasRegistradas[25].lugarCasa.escuelas = 1;
            casasRegistradas[25].lugarCasa.centrosComerciales = 3;
            casasRegistradas[25].lugarCasa.transporte = 2;
            casasRegistradas[25].modelo = "Vivienda";
            casasRegistradas[25].cuartos = 2;
            casasRegistradas[25].banos = 2;
            casasRegistradas[25].parqueaderos = "No";
            casasRegistradas[25].espacioVerdes = "Si";
            casasRegistradas[25].precioCasa = 38000;
            //27 
            casasRegistradas[26].lugarCasa.sector = "Sur";
            casasRegistradas[26].lugarCasa.parques = 1;
            casasRegistradas[26].lugarCasa.escuelas = 3;
            casasRegistradas[26].lugarCasa.centrosComerciales = 1;
            casasRegistradas[26].lugarCasa.transporte = 2;
            casasRegistradas[26].modelo = "Condominio";
            casasRegistradas[26].cuartos = 1;
            casasRegistradas[26].banos = 1;
            casasRegistradas[26].parqueaderos = "No";
            casasRegistradas[26].espacioVerdes = "No";
            casasRegistradas[26].precioCasa = 59000;
            //28 
            casasRegistradas[27].lugarCasa.sector = "Sur";
            casasRegistradas[27].lugarCasa.parques = 1;
            casasRegistradas[27].lugarCasa.escuelas = 2;
            casasRegistradas[27].lugarCasa.centrosComerciales = 1;
            casasRegistradas[27].lugarCasa.transporte = 1;
            casasRegistradas[27].modelo = "Condominio";
            casasRegistradas[27].cuartos = 2;
            casasRegistradas[27].banos = 2;
            casasRegistradas[27].parqueaderos = "Si";
            casasRegistradas[27].espacioVerdes = "No";
            casasRegistradas[27].precioCasa = 60000;
            //29 
            casasRegistradas[28].lugarCasa.sector = "Sur";
            casasRegistradas[28].lugarCasa.parques = 3;
            casasRegistradas[28].lugarCasa.escuelas = 5;
            casasRegistradas[28].lugarCasa.centrosComerciales = 2;
            casasRegistradas[28].lugarCasa.transporte = 3;
            casasRegistradas[28].modelo = "Departamento";
            casasRegistradas[28].cuartos = 3;
            casasRegistradas[28].banos = 2;
            casasRegistradas[28].parqueaderos = "No";
            casasRegistradas[28].espacioVerdes = "No";
            casasRegistradas[28].precioCasa = 70000;
            //30 
            casasRegistradas[29].lugarCasa.sector = "Sur";
            casasRegistradas[29].lugarCasa.parques = 2;
            casasRegistradas[29].lugarCasa.escuelas = 4;
            casasRegistradas[29].lugarCasa.centrosComerciales = 2;
            casasRegistradas[29].lugarCasa.transporte = 1;
            casasRegistradas[29].modelo = "Vivienda";
            casasRegistradas[29].cuartos = 3;
            casasRegistradas[29].banos = 3;
            casasRegistradas[29].parqueaderos = "Si";
            casasRegistradas[29].espacioVerdes = "Si";
            casasRegistradas[29].precioCasa = 39000;
            //FIN DE CASAS REGISTRADAS
            try
            {
                Persona persona1 = new Persona(); //constructor de una nueva persona
                persona1.nombre = txtNombre.Text; //obtener el texto de un text box
                persona1.presupuesto = Convert.ToDouble(txtPresupuesto.Text, System.Globalization.CultureInfo.GetCultureInfo("es-ES")); //para convertir a double
                txaRecibo.Clear();
                //llamada a la clase forma de pago
                FormaDePago(casasRegistradas, busqueda, persona1);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifica tus datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //instrucciones para el boton intentelo de nuevo
        private void btnIntenteDeNuevo_Click(object sender, EventArgs e)
        {
            //borrar text box:
            txtNombre.Clear();
            txtPresupuesto.Clear();
            txtCuartos.Clear();
            txtBanos.Clear();
            txtParques.Clear();
            txtEscuelas.Clear();
            txtCeCo.Clear();
            txtTransporte.Clear();
            //borrar la eleccion radio buton
            rbVivienda.Checked = false;
            rbCondominio.Checked = false;
            rbDepartamento.Checked = false;
            rbSur.Checked = false;
            rbCentro.Checked = false;
            rbNorte.Checked = false;
            rbSiP.Checked = false;
            rbNoP.Checked = false;
            rbSiE.Checked = false;
            rbNoE.Checked = false;
            //borrar los texts de box de busqueda
            txaBusqueda.Clear();
            txtCuotas.Hide();
            lbCuotas.Hide();
            btnConfirmar.Hide();
            rbCredito.Enabled = false;
            rbEfectivo.Enabled = false;
            btnComprar.Enabled = false;
            txaRecibo.Clear();
        }
        //inicio de las validaciones respectivas para todas las texts boxs 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetras(e);
        }

        private void txtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void txtCuartos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void txtParques_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void txtEscuelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void txtBanos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void txtCeCo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void txtTransporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }

        private void linkLbManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("IExplore", "https://drive.google.com/file/d/11D4oOA-K1gncnXvZ8odQqrte5OF_uV99/view?usp=sharing");
        }
    }
}
