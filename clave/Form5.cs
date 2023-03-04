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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int j1 = 0;
        int j2 = 0;
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Piedra1.Enabled = true;
            Papel1.Enabled = true;
            Tijera1.Enabled = true;
            piedra2.Enabled = true;
            Papel2.Enabled = true;
            Tijera2.Enabled = true;
            j1 = 0;


        }

        private void Piedra1_Click(object sender, EventArgs e)
        {
            j1 = 1;
            Piedra1.Enabled = false;
            Papel1.Enabled = false;
            Tijera1.Enabled= false;

            if (j2 == 1)
            {
                MessageBox.Show("Empate!!!!");

            }
            if (j2 == 2)
            {
                int puntos = Convert.ToInt16(puntaje2.Text);
                puntaje2.Text = Convert.ToString(puntos + 1);
            }
            if (j2 == 3)
            {
                int puntos = Convert.ToInt16(puntaje1.Text);
                puntaje1.Text = Convert.ToString(puntos + 1);
            }


        }

        private void Papel2_Click(object sender, EventArgs e)
        {
            j2 = 2;
            piedra2.Enabled = false;
            Papel2.Enabled= false;
            Tijera2.Enabled= false;

            if(j1== 1)
            {
                int puntos = Convert.ToInt16(puntaje2.Text);
                puntaje2.Text = Convert.ToString(puntos+1);

            }
            if(j1== 2)
            {
                MessageBox.Show("Empate!!!!");
            }
            if(j1== 3)
            {
                int puntos = Convert.ToInt16(puntaje1.Text);
                puntaje1.Text = Convert.ToString(puntos + 1);
            }
        }

        private void Papel1_Click(object sender, EventArgs e)
        {
            j1 = 2; 
            Piedra1.Enabled = false;
            Papel1.Enabled = false;
            Tijera1.Enabled = false;

            if (j2 == 1)
            {
                int puntos = Convert.ToInt16(puntaje1.Text);
                puntaje1.Text = Convert.ToString(puntos + 1);

            }
            if (j2 == 2)
            {
                MessageBox.Show("Empate!!!!");
            }
            if (j2 == 3)
            {
                int puntos = Convert.ToInt16(puntaje2.Text);
                puntaje2.Text = Convert.ToString(puntos + 1);
            }

        }

        private void Tijera1_Click(object sender, EventArgs e)
        {
            j1 = 3;
            Piedra1.Enabled = false;
            Papel1.Enabled = false;
            Tijera1.Enabled = false;

            if (j2 == 1)
            {
                int puntos = Convert.ToInt16(puntaje2.Text);
                puntaje2.Text = Convert.ToString(puntos + 1);

            }
            if (j2 == 2)
            {
                int puntos = Convert.ToInt16(puntaje1.Text);
                puntaje1.Text = Convert.ToString(puntos + 1);
            }
            if (j2 == 3)
            {
                MessageBox.Show("Empate!!!!");
            }
        }

        private void piedra2_Click(object sender, EventArgs e)
        {
            j2 = 1;
            piedra2.Enabled = false;
            Papel2.Enabled = false;
            Tijera2.Enabled = false;

            if (j1 == 1)
            {
                MessageBox.Show("Empate!!!!");

            }
            if (j1 == 2)
            {
                int puntos = Convert.ToInt16(puntaje1.Text);
                puntaje1.Text = Convert.ToString(puntos + 1);
            }
            if (j1 == 3)
            {
                int puntos = Convert.ToInt16(puntaje2.Text);
                puntaje2.Text = Convert.ToString(puntos + 1);
            }
        }

        private void Tijera2_Click(object sender, EventArgs e)
        {
            j2 = 3;

            piedra2.Enabled = false;
            Papel2.Enabled = false;
            Tijera2.Enabled = false;

            if (j1 == 1)
            {
                int puntos = Convert.ToInt16(puntaje1.Text);
                puntaje1.Text = Convert.ToString(puntos + 1);

            }
            if (j1 == 2)
            {
                int puntos = Convert.ToInt16(puntaje2.Text);
                puntaje2.Text = Convert.ToString(puntos + 1);
            }
            if (j1 == 3)
            {
                MessageBox.Show("Empate!!!!");
            }
        }
    }
}
