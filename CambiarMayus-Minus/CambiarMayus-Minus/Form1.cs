using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambiarMayus_Minus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool textOk = true;
            string texto = "";

            if (String.IsNullOrEmpty(textEntrada.Text))
            {
                MessageBox.Show("Debe introducir un texto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textOk = false;
            }
            else
            {
                texto = textEntrada.Text;
            }
            

            if (!radioButton1.Checked & !radioButton2.Checked)
            {
                MessageBox.Show("Debe seleccionar una de las dos opciones", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            } else
            {
                if (radioButton1.Checked & textOk) //Mayúsculas
                {
                    textSalida.Text = texto.ToUpper();
                }
                else if (radioButton2.Checked & textOk)
                {
                    textSalida.Text = texto.ToLower();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textEntrada.Text = "";
            textSalida.Text = "";            
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
