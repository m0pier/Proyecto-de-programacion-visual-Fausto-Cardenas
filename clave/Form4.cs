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
    public partial class Form4 : Form
    {

        string nombre = "";
        string ciudad = "";
        string telefono = "";
        string correo = "";
        string valor = "";
        int posicion = 0;
        bool actualizar = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            ciudad = textBox2.Text;
            telefono = textBox3.Text;
            correo = textBox4.Text;

            listBox1.Items.Add(nombre + ' ' + ciudad + ' ' +telefono + ' ' + correo);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = "";
            valor =
            listBox1.GetItemText(listBox1.SelectedItem); posicion = listBox1.SelectedIndex;
            //MessageBox.Show("Valor" + valor + ' ' + posicion);
            //txtNombre.Text = "eeeee"+contador;
            //contador++;
            // modificoCampos (valor);
            if (actualizar)
            {
            }
            else
            {
                modificoCampos(valor);
            }
        }

        private void modificoCampos(String valor)
        {
            if (valor.Equals(""))
            {
            }
            else
            {
                string[] subs;
                subs = valor.Split(' ');
                nombre = subs[0];
                ciudad = subs[1];
                telefono = subs[2];
                correo = subs[3];
                textBox1.Text = nombre;
                textBox2.Text = ciudad;
                textBox3.Text = telefono;
                textBox4.Text = correo;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar = true;
            int nposicion = 0;
            string valor2 = "";
            nombre = textBox1.Text;
            ciudad = textBox3.Text;
            telefono = textBox2.Text;
            correo = textBox4.Text;
            valor2 = nombre + ' ' + ciudad + ' ' + telefono + ' ' + correo;
            nposicion = listBox1.SelectedIndex;
            //MessageBox.Show("valor " + nposicion);
            listBox1.Items.RemoveAt(nposicion);
            listBox1.Items.Insert(nposicion, valor2);
            actualizar = false;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nposicion = 0;
            nposicion = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(nposicion);

        }
    }
}
