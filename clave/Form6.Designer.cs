namespace Clave
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btVender = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.txtEfectivo);
            this.panel1.Controls.Add(this.lblDevolucion);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btEliminar);
            this.panel1.Controls.Add(this.btAgregar);
            this.panel1.Controls.Add(this.cmbproducto);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvLista);
            this.panel1.Location = new System.Drawing.Point(43, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 687);
            this.panel1.TabIndex = 0;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(234, 625);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(125, 27);
            this.txtEfectivo.TabIndex = 19;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Location = new System.Drawing.Point(463, 625);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(15, 20);
            this.lblDevolucion.TabIndex = 18;
            this.lblDevolucion.Text = "-";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(108, 625);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 20);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(414, 565);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Devolucion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(253, 565);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 28);
            this.label11.TabIndex = 15;
            this.label11.Text = "Efectivo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(62, 565);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total a pagar";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(428, 159);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(133, 66);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(428, 67);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(133, 66);
            this.btAgregar.TabIndex = 12;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Items.AddRange(new object[] {
            "Granizado pequeño",
            "Granizado mediano",
            "Granizado grande",
            "Helado mediano con queso",
            "Helado grande con queso"});
            this.cmbproducto.Location = new System.Drawing.Point(199, 19);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(197, 28);
            this.cmbproducto.TabIndex = 11;
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(199, 202);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 27);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(208, 159);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(15, 20);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "-";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(208, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(15, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "-";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(208, 71);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(15, 20);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(78, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(84, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(84, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(84, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvLista.Location = new System.Drawing.Point(28, 262);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 29;
            this.dgvLista.Size = new System.Drawing.Size(569, 279);
            this.dgvLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura Heladeria";
            // 
            // btVender
            // 
            this.btVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btVender.Location = new System.Drawing.Point(209, 786);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(259, 66);
            this.btVender.TabIndex = 14;
            this.btVender.Text = "Vender";
            this.btVender.UseVisualStyleBackColor = false;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 876);
            this.Controls.Add(this.btVender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heladeria";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox txtEfectivo;
        private Label lblDevolucion;
        private Label lblTotal;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btEliminar;
        private Button btAgregar;
        private ComboBox cmbproducto;
        private TextBox txtCantidad;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblCodigo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvLista;
        private Label label1;
        private Button btVender;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}