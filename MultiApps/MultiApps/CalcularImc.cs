using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiApps
{
    public partial class CalcularImc : Form
    {
        public CalcularImc()
        {
            InitializeComponent();
        }

        private void CalcularImc_Load(object sender, EventArgs e)
        {

        }

        private double calcularIMC()
        {

            const int bajoPeso = -1;
            const int pesoIdeal = 0;
            const int sobrePeso = 1;

            double resultado = Convert.ToDouble(txtPeso.Text) / (Convert.ToDouble(txtAltura.Text) * Convert.ToDouble(txtAltura.Text));

            if (resultado < 20)
            {
                return bajoPeso;
            }
            else if (resultado > 20 && resultado <= 25)
            {
                return pesoIdeal;
            }
            else if (resultado > 25)
            {
                return sobrePeso;
            }
            return resultado;

        }

        private bool esMayorDeEdad()
        {
            Boolean mayorDeEdad = true;
            Boolean menorDeEdad = false;
            int esMayor = Convert.ToInt32(txtEdad.Text);

            if (esMayor < 21)
            {
                return menorDeEdad;
            }
            else
            {
                return mayorDeEdad;
            }
        }

        private void btnCalcularPeso_Click(object sender, EventArgs e)
        {
            double calcular = calcularIMC();
            bool nose = esMayorDeEdad();
            string edadd = "Es Mayor de Edad";
            string edaddd = "Es menor de Edad";

            if (nose == true)
            {
                lstResultado.Items.Add(edadd);
            }
            else
            {
                lstResultado.Items.Add(edaddd);
            }
            lstResultado.Items.Add(calcular);
        }
    }
}
