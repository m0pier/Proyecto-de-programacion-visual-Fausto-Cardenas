namespace Clave
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Piedra1 = new System.Windows.Forms.Button();
            this.Papel1 = new System.Windows.Forms.Button();
            this.Tijera1 = new System.Windows.Forms.Button();
            this.piedra2 = new System.Windows.Forms.Button();
            this.Papel2 = new System.Windows.Forms.Button();
            this.Tijera2 = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.puntaje1 = new System.Windows.Forms.Label();
            this.puntaje2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(265, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "JUGADOR 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(682, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "JUGADOR 2";
            // 
            // Piedra1
            // 
            this.Piedra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Piedra1.BackgroundImage")));
            this.Piedra1.Location = new System.Drawing.Point(294, 91);
            this.Piedra1.Name = "Piedra1";
            this.Piedra1.Size = new System.Drawing.Size(115, 149);
            this.Piedra1.TabIndex = 2;
            this.Piedra1.UseVisualStyleBackColor = true;
            this.Piedra1.Click += new System.EventHandler(this.Piedra1_Click);
            // 
            // Papel1
            // 
            this.Papel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Papel1.BackgroundImage")));
            this.Papel1.Location = new System.Drawing.Point(294, 255);
            this.Papel1.Name = "Papel1";
            this.Papel1.Size = new System.Drawing.Size(126, 165);
            this.Papel1.TabIndex = 3;
            this.Papel1.UseVisualStyleBackColor = true;
            this.Papel1.Click += new System.EventHandler(this.Papel1_Click);
            // 
            // Tijera1
            // 
            this.Tijera1.BackgroundImage = global::Clave.Properties.Resources.Tijera;
            this.Tijera1.Location = new System.Drawing.Point(298, 451);
            this.Tijera1.Name = "Tijera1";
            this.Tijera1.Size = new System.Drawing.Size(122, 162);
            this.Tijera1.TabIndex = 4;
            this.Tijera1.UseVisualStyleBackColor = true;
            this.Tijera1.Click += new System.EventHandler(this.Tijera1_Click);
            // 
            // piedra2
            // 
            this.piedra2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piedra2.BackgroundImage")));
            this.piedra2.Location = new System.Drawing.Point(725, 91);
            this.piedra2.Name = "piedra2";
            this.piedra2.Size = new System.Drawing.Size(115, 149);
            this.piedra2.TabIndex = 5;
            this.piedra2.UseVisualStyleBackColor = true;
            this.piedra2.Click += new System.EventHandler(this.piedra2_Click);
            // 
            // Papel2
            // 
            this.Papel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Papel2.BackgroundImage")));
            this.Papel2.Location = new System.Drawing.Point(714, 255);
            this.Papel2.Name = "Papel2";
            this.Papel2.Size = new System.Drawing.Size(126, 165);
            this.Papel2.TabIndex = 6;
            this.Papel2.UseVisualStyleBackColor = true;
            this.Papel2.Click += new System.EventHandler(this.Papel2_Click);
            // 
            // Tijera2
            // 
            this.Tijera2.BackgroundImage = global::Clave.Properties.Resources.Tijera;
            this.Tijera2.Location = new System.Drawing.Point(714, 451);
            this.Tijera2.Name = "Tijera2";
            this.Tijera2.Size = new System.Drawing.Size(122, 162);
            this.Tijera2.TabIndex = 7;
            this.Tijera2.UseVisualStyleBackColor = true;
            this.Tijera2.Click += new System.EventHandler(this.Tijera2_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnreset.Location = new System.Drawing.Point(452, 662);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(214, 110);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "RESETEAR";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "PUNTAJE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(947, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "PUNTAJE";
            // 
            // puntaje1
            // 
            this.puntaje1.AutoSize = true;
            this.puntaje1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puntaje1.Location = new System.Drawing.Point(125, 291);
            this.puntaje1.Name = "puntaje1";
            this.puntaje1.Size = new System.Drawing.Size(27, 32);
            this.puntaje1.TabIndex = 11;
            this.puntaje1.Text = "0";
            // 
            // puntaje2
            // 
            this.puntaje2.AutoSize = true;
            this.puntaje2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puntaje2.Location = new System.Drawing.Point(987, 291);
            this.puntaje2.Name = "puntaje2";
            this.puntaje2.Size = new System.Drawing.Size(27, 32);
            this.puntaje2.TabIndex = 12;
            this.puntaje2.Text = "0";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 816);
            this.Controls.Add(this.puntaje2);
            this.Controls.Add(this.puntaje1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.Tijera2);
            this.Controls.Add(this.Papel2);
            this.Controls.Add(this.piedra2);
            this.Controls.Add(this.Tijera1);
            this.Controls.Add(this.Papel1);
            this.Controls.Add(this.Piedra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piedra, Papel o Tijera";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Piedra1;
        private Button Papel1;
        private Button Tijera1;
        private Button piedra2;
        private Button Papel2;
        private Button Tijera2;
        private Button btnreset;
        private Label label3;
        private Label label4;
        private Label puntaje1;
        private Label puntaje2;
    }
}