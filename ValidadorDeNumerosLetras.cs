using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasDeCasaUIO
{
    public class ValidadorDeNumerosLetras
    {
        public void ValidarLetras(KeyPressEventArgs e) 
        {
            if (Char.IsLetter(e.KeyChar)) //si la tecla que presiona es una letra
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))//si la tecla que presiona es un espacio   
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))//si la tecla que presiona es una tecla de control 
            {
                e.Handled = false;
            }
            else //sino cumple con lo anterior ponemos una caja de error
            {
                e.Handled = true;
                MessageBox.Show("Ingresa solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void ValidarNumeros(KeyPressEventArgs e) 
        {

            if (Char.IsNumber(e.KeyChar)) //si la tecla que presiona es un numero
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))//si la tecla que presione es una tecla de control como borrar
            {
                e.Handled = false;
            }
            else //sino cumple con lo anterior ponemos una caja de error
            {
                e.Handled = true;
                MessageBox.Show("Ingresa solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
