namespace Clave
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo;
            string nombre;
            float precio;

            codigo = cmbproducto.SelectedIndex;
            nombre = cmbproducto.SelectedItem.ToString();
            precio = cmbproducto.SelectedIndex;

            switch (codigo)
            {
                case 0: lblCodigo.Text = "001"; break;
                case 1: lblCodigo.Text = "002"; break;
                case 2: lblCodigo.Text = "003"; break;
                case 3: lblCodigo.Text = "003"; break;
                case 4: lblCodigo.Text = "003"; break;
            }

            switch (nombre)
            {
                case "Granizado pequeño": lblNombre.Text = "Granizado pequeño"; break;
                case "Granizado mediano": lblNombre.Text = "Granizado mediano"; break;
                case "Granizado grande": lblNombre.Text = "Granizado grande"; break;
                case "Helado mediano con queso": lblNombre.Text = "Helado mediano con queso"; break;
                case "Helado grande con queso": lblNombre.Text = "Helado grande con queso"; break;

            }

            switch (precio)
            {
                case 0: lblPrecio.Text = "0,50"; break;
                case 1: lblPrecio.Text = "1,00"; break;
                case 2: lblPrecio.Text = "2,00"; break;
                case 3: lblPrecio.Text = "1,50"; break;
                case 4: lblPrecio.Text = "2,50"; break;

            }

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvLista);

            file.Cells[0].Value = lblCodigo.Text;
            file.Cells[1].Value = lblNombre.Text;
            file.Cells[2].Value = lblPrecio.Text;
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = (float.Parse(lblPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

            dgvLista.Rows.Add(file);

            lblCodigo.Text = lblNombre.Text = lblPrecio.Text = txtCantidad.Text = "";

            obtenerTotal();
        }

        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;

            contador = dgvLista.RowCount;

            for(int i = 0; i < contador; i++)
            {
                costot += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }

            lblTotal.Text = costot.ToString();

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("Desea eliminar el producto?", 
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dgvLista.Rows.Remove(dgvLista.CurrentRow);
                }
            }
            catch
            {

            }
            obtenerTotal();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotal.Text)).ToString();

            }
            catch
            {

            }
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            ClsFactura.CreaTicket Ticket1 = new ClsFactura.CreaTicket();

            Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            ClsFactura.CreaTicket.LineasGuion();

            ClsFactura.CreaTicket.EncabezadoVenta();
            ClsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            ClsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblTotal.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

            this.Close();
        
        }
    }
}
