namespace casodearbol
{
    partial class GraFo
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
            this.LblEdificio = new System.Windows.Forms.Label();
            this.LblDistancia = new System.Windows.Forms.Label();
            this.TboxEdificio = new System.Windows.Forms.TextBox();
            this.LblConexiones = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblOrigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEdificio
            // 
            this.LblEdificio.AutoSize = true;
            this.LblEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdificio.Location = new System.Drawing.Point(3, 52);
            this.LblEdificio.Name = "LblEdificio";
            this.LblEdificio.Size = new System.Drawing.Size(221, 33);
            this.LblEdificio.TabIndex = 0;
            this.LblEdificio.Text = "Agregar Edificio";
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistancia.Location = new System.Drawing.Point(2, 114);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(149, 37);
            this.LblDistancia.TabIndex = 1;
            this.LblDistancia.Text = "Distancia";
            this.LblDistancia.Click += new System.EventHandler(this.label1_Click);
            // 
            // TboxEdificio
            // 
            this.TboxEdificio.Location = new System.Drawing.Point(231, 65);
            this.TboxEdificio.Name = "TboxEdificio";
            this.TboxEdificio.Size = new System.Drawing.Size(215, 20);
            this.TboxEdificio.TabIndex = 2;
            // 
            // LblConexiones
            // 
            this.LblConexiones.AutoSize = true;
            this.LblConexiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConexiones.Location = new System.Drawing.Point(12, 267);
            this.LblConexiones.Name = "LblConexiones";
            this.LblConexiones.Size = new System.Drawing.Size(169, 33);
            this.LblConexiones.TabIndex = 3;
            this.LblConexiones.Text = "Conexiones";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 5;
            // 
            // LblOrigen
            // 
            this.LblOrigen.AutoSize = true;
            this.LblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrigen.Location = new System.Drawing.Point(12, 183);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(103, 33);
            this.LblOrigen.TabIndex = 6;
            this.LblOrigen.Text = "Origen";
            // 
            // GraFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.LblOrigen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblConexiones);
            this.Controls.Add(this.TboxEdificio);
            this.Controls.Add(this.LblDistancia);
            this.Controls.Add(this.LblEdificio);
            this.Name = "GraFo";
            this.Text = "GraFo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEdificio;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.TextBox TboxEdificio;
        private System.Windows.Forms.Label LblConexiones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblOrigen;
    }
}