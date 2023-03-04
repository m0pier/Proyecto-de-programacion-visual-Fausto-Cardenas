namespace Clave
{
    public partial class Form1 : Form
    {
        int contador = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textusuario.Text;
            string clave = textBox1.Text;

            if (usuario == "Emilio" && clave == "1234")
            {
                this.Hide();
                Form2 fr = new Form2();
                fr.Show();


            }
            else
            {
                if (contador > 3)
                {
                    MessageBox.Show("Excedio el numero de intentos disponibles");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son los correctos");
                    textusuario.Text = "";
                    textBox1.Text = "";
                    textusuario.Focus();

                }
                contador++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}