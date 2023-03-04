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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.png");
            this.BackgroundImage= img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void calculadoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.MdiParent = this;
            calculadora.Show();

        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {

                Form4 contactos = new Form4();
                contactos.MdiParent = this;
                contactos.Show();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void juegoDePPoTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 juegoPPT= new Form5();
            juegoPPT.MdiParent = this;
            juegoPPT.Show();
        }

        private void facturadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Facturadora = new Form6();
            Facturadora.MdiParent = this;
            Facturadora.Show();
        }
    }
}
