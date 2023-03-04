using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        decimal dividendo = 0;
        decimal divisor = 0;
        string operacion = "";


        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            dividendo = decimal.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "division";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+button2.Text;
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textBox1.Text);
            divisor = decimal.Parse(textBox1.Text);
            decimal resultado = 0;
            switch (operacion)
            {
                case "suma":
                    resultado = dividendo + divisor;
                    textBox1.Text = resultado.ToString();
                    operacion = "";

                    break;
                case "resta":
                    resultado = dividendo - divisor;
                    textBox1.Text = resultado.ToString();
                    operacion = "";

                    break;
                case "multiplicacion":
                    resultado = dividendo * divisor;
                    textBox1.Text = resultado.ToString();
                    operacion = "";

                    break;
                case "division":
                    try
                    {
                        resultado = dividendo / divisor;
                        textBox1.Text = resultado.ToString();
                        operacion = "";
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("{0} Exception caught.", ex);
                    }



                    break;


            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "suma";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "resta";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "multiplicacion";
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
