using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string ValidarEntrada(string valor)
        {
            Convert.ToDouble(valor);
            return valor;
        }

        public void OperacionSuma()
        {
            try
            {
                string resultado;

                resultado = (Convert.ToDouble(ValidarEntrada(txtValor1.Text)) + Convert.ToDouble(ValidarEntrada(txtValor2.Text)) ).ToString();

                txtResultado.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Se ha producido una exepcion del tipo formato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Uno de los numeros esta fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonResultado_Click(object sender, EventArgs e)
        {
            OperacionSuma();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            foreach(Control Con in this.Controls)
            {
                if(Con is TextBox)
                {
                    Con.Text = "0";
                }
            }

            txtValor1.Focus();
        }
    }
}
