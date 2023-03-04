namespace Clave
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoDePPoTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.juegoDePPoTToolStripMenuItem,
            this.facturadoraToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.aToolStripMenuItem.Text = "Archivo";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click_1);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contactosToolStripMenuItem.Text = "Contactos";
            this.contactosToolStripMenuItem.Click += new System.EventHandler(this.contactosToolStripMenuItem_Click);
            // 
            // juegoDePPoTToolStripMenuItem
            // 
            this.juegoDePPoTToolStripMenuItem.Name = "juegoDePPoTToolStripMenuItem";
            this.juegoDePPoTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.juegoDePPoTToolStripMenuItem.Text = "Juego de P,PoT";
            this.juegoDePPoTToolStripMenuItem.Click += new System.EventHandler(this.juegoDePPoTToolStripMenuItem_Click);
            // 
            // facturadoraToolStripMenuItem
            // 
            this.facturadoraToolStripMenuItem.Name = "facturadoraToolStripMenuItem";
            this.facturadoraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facturadoraToolStripMenuItem.Text = "Facturadora";
            this.facturadoraToolStripMenuItem.Click += new System.EventHandler(this.facturadoraToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1071, 479);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Multitareas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem contactosToolStripMenuItem;
        private ToolStripMenuItem juegoDePPoTToolStripMenuItem;
        private ToolStripMenuItem facturadoraToolStripMenuItem;
    }
}