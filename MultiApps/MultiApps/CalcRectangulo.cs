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
    public partial class CalcRectangulo : Form
    {
        public CalcRectangulo()
        {
            InitializeComponent();
        }

        private void CalcRectangulo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = calcularArea();

            lstResultado.Items.Add(resultado);

            limpiarCampos();
        }

        private void texBase_TextChanged(object sender, EventArgs e)
        {

        }


        private int calcularArea()
        {
            int calArea = Convert.ToInt32(texAltura.Text) * Convert.ToInt32(texBase.Text);
            return calArea;

        }
        public int calcularPerimetro()
        {

            int calPer = (Convert.ToInt32(texAltura.Text) * 2) + (Convert.ToInt32(texBase.Text) * 2);
            return calPer;


        }


        private void limpiarCampos()
        {
            texAltura.Text = "";
            texBase.Text = "";
        }

        private void calcPerimetro_Click(object sender, EventArgs e)
        {
            int calcular = calcularPerimetro();

            lstResultado.Items.Add(calcular);

            limpiarCampos();
        }
    }
}
