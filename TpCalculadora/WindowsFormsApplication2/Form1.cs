using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculadora";
            cmbOperacion.Items.Add("/");
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("-");
        }

        /// <summary>
        /// Crea una calculadora y realiza la operacion segun los numeros y el operador ingresado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                Numero Numero1 = new Numero(txtNumero1.Text);
                Numero Numero2 = new Numero(txtNumero2.Text);
                Calculadora c = new Calculadora();
                bool validar = c.validarOperador(cmbOperacion.Text);
                if (validar == true)
                {
                    string Resultado = c.operar(Numero1, Numero2, cmbOperacion.Text);
                    lblResultado.Text = "Resultado:" + Resultado;
                }
                    else
                    {
                        lblResultado.Text = "Operador no valido";
                    }
                }
            catch (Exception)
            {

                lblResultado.Text = "Debe ingresar 2 numeros";
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Limpia los textbox
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }

        /// <summary>
        /// Llama a la funcion limpiar, que limpia los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
