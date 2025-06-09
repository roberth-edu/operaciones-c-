using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double suma, n1, n2;
            if (double.TryParse(txtIngresarUno.Text, out n1) && double.TryParse(txtIngresarDos.Text, out n2))
            { 
                suma = n1 + n2;
                lblResultado.Text = "la suma sera igual a "+suma.ToString("N2");
            }
            else
            {
                lblResultado.Text = "porfavor ingrese un valor valido";
            }
              
            
           
        }

        private void txtIngresarUno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngresarDos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero2_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double dividir, n1, n2;
            if (double.TryParse(txtIngresarUno.Text,out n1) && double.TryParse(txtIngresarDos.Text,out n2))
            {
                if (n2 != 0) {
                dividir = n1 / n2;
                lblResultado.Text = "la division sera igual a " + dividir.ToString("N2");
            }
            else
            {
                    lblResultado.Text = "porfavor ingrese un valor valido";
            }



        }
    }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double resta, n1, n2;
            if (double.TryParse(txtIngresarUno.Text, out n1) && double.TryParse(txtIngresarDos.Text, out n2))
            {
                resta = n1 - n2;
                lblResultado.Text = "la resta sera " + resta.ToString();
            }
            else
            {
                lblResultado.Text = "porfavor ingrese un valor valido";
            }
            }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double multi, n1, n2;
            if (double.TryParse(txtIngresarUno.Text, out n1) && double.TryParse(txtIngresarDos.Text, out n2))
            {
                multi = n1 * n2;
                lblResultado.Text = "la multiplicacion sera " + multi.ToString();
            }
            else
            {
                lblResultado.Text = "porfavor ingrese un valor valido";
            }

        }
    }
}
