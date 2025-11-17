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
            this.TboxDistancia = new System.Windows.Forms.TextBox();
            this.LblOrigen = new System.Windows.Forms.Label();
            this.TboxOrigen = new System.Windows.Forms.TextBox();
            this.ListBoxEdificios = new System.Windows.Forms.ListBox();
            this.BtnAgregarEdificio = new System.Windows.Forms.Button();
            this.BtnAggConexion = new System.Windows.Forms.Button();
            this.BtnMostrarConexiones = new System.Windows.Forms.Button();
            this.BtnRutaMasCorta = new System.Windows.Forms.Button();
            this.BtnValidarConexidad = new System.Windows.Forms.Button();
            this.TboxDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEdificio
            // 
            this.LblEdificio.AutoSize = true;
            this.LblEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdificio.Location = new System.Drawing.Point(3, 19);
            this.LblEdificio.Name = "LblEdificio";
            this.LblEdificio.Size = new System.Drawing.Size(221, 33);
            this.LblEdificio.TabIndex = 0;
            this.LblEdificio.Text = "Agregar Edificio";
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistancia.Location = new System.Drawing.Point(2, 76);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(149, 37);
            this.LblDistancia.TabIndex = 1;
            this.LblDistancia.Text = "Distancia";
            this.LblDistancia.Click += new System.EventHandler(this.label1_Click);
            // 
            // TboxEdificio
            // 
            this.TboxEdificio.Location = new System.Drawing.Point(230, 32);
            this.TboxEdificio.Name = "TboxEdificio";
            this.TboxEdificio.Size = new System.Drawing.Size(215, 20);
            this.TboxEdificio.TabIndex = 2;
            this.TboxEdificio.TextChanged += new System.EventHandler(this.TboxEdificio_TextChanged);
            // 
            // TboxDistancia
            // 
            this.TboxDistancia.Location = new System.Drawing.Point(157, 91);
            this.TboxDistancia.Name = "TboxDistancia";
            this.TboxDistancia.Size = new System.Drawing.Size(128, 20);
            this.TboxDistancia.TabIndex = 5;
            // 
            // LblOrigen
            // 
            this.LblOrigen.AutoSize = true;
            this.LblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrigen.Location = new System.Drawing.Point(12, 347);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(103, 33);
            this.LblOrigen.TabIndex = 6;
            this.LblOrigen.Text = "Origen";
            // 
            // TboxOrigen
            // 
            this.TboxOrigen.Location = new System.Drawing.Point(124, 360);
            this.TboxOrigen.Name = "TboxOrigen";
            this.TboxOrigen.Size = new System.Drawing.Size(100, 20);
            this.TboxOrigen.TabIndex = 7;
            this.TboxOrigen.TextChanged += new System.EventHandler(this.TboxOrigen_TextChanged);
            // 
            // ListBoxEdificios
            // 
            this.ListBoxEdificios.FormattingEnabled = true;
            this.ListBoxEdificios.Location = new System.Drawing.Point(380, 68);
            this.ListBoxEdificios.Name = "ListBoxEdificios";
            this.ListBoxEdificios.Size = new System.Drawing.Size(432, 303);
            this.ListBoxEdificios.TabIndex = 8;
            // 
            // BtnAgregarEdificio
            // 
            this.BtnAgregarEdificio.Location = new System.Drawing.Point(471, 8);
            this.BtnAgregarEdificio.Name = "BtnAgregarEdificio";
            this.BtnAgregarEdificio.Size = new System.Drawing.Size(129, 54);
            this.BtnAgregarEdificio.TabIndex = 9;
            this.BtnAgregarEdificio.Text = "Agregar Edificio";
            this.BtnAgregarEdificio.UseVisualStyleBackColor = true;
            this.BtnAgregarEdificio.Click += new System.EventHandler(this.BtnAgregarEdificio_Click);
            // 
            // BtnAggConexion
            // 
            this.BtnAggConexion.Location = new System.Drawing.Point(40, 176);
            this.BtnAggConexion.Name = "BtnAggConexion";
            this.BtnAggConexion.Size = new System.Drawing.Size(75, 66);
            this.BtnAggConexion.TabIndex = 10;
            this.BtnAggConexion.Text = "Agregar Conexion";
            this.BtnAggConexion.UseVisualStyleBackColor = true;
            this.BtnAggConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // BtnMostrarConexiones
            // 
            this.BtnMostrarConexiones.Location = new System.Drawing.Point(132, 173);
            this.BtnMostrarConexiones.Name = "BtnMostrarConexiones";
            this.BtnMostrarConexiones.Size = new System.Drawing.Size(75, 66);
            this.BtnMostrarConexiones.TabIndex = 11;
            this.BtnMostrarConexiones.Text = "Mostrar Conexiones";
            this.BtnMostrarConexiones.UseVisualStyleBackColor = true;
            this.BtnMostrarConexiones.Click += new System.EventHandler(this.BtnMostrarC_Click);
            // 
            // BtnRutaMasCorta
            // 
            this.BtnRutaMasCorta.Location = new System.Drawing.Point(236, 333);
            this.BtnRutaMasCorta.Name = "BtnRutaMasCorta";
            this.BtnRutaMasCorta.Size = new System.Drawing.Size(138, 54);
            this.BtnRutaMasCorta.TabIndex = 12;
            this.BtnRutaMasCorta.Text = "Ruta Mas corta";
            this.BtnRutaMasCorta.UseVisualStyleBackColor = true;
            // 
            // BtnValidarConexidad
            // 
            this.BtnValidarConexidad.Location = new System.Drawing.Point(236, 176);
            this.BtnValidarConexidad.Name = "BtnValidarConexidad";
            this.BtnValidarConexidad.Size = new System.Drawing.Size(81, 63);
            this.BtnValidarConexidad.TabIndex = 13;
            this.BtnValidarConexidad.Text = "Validar Conexidad";
            this.BtnValidarConexidad.UseVisualStyleBackColor = true;
            // 
            // TboxDestino
            // 
            this.TboxDestino.Location = new System.Drawing.Point(132, 307);
            this.TboxDestino.Name = "TboxDestino";
            this.TboxDestino.Size = new System.Drawing.Size(129, 20);
            this.TboxDestino.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Destino";
            // 
            // GraFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TboxDestino);
            this.Controls.Add(this.BtnValidarConexidad);
            this.Controls.Add(this.BtnRutaMasCorta);
            this.Controls.Add(this.BtnMostrarConexiones);
            this.Controls.Add(this.BtnAggConexion);
            this.Controls.Add(this.BtnAgregarEdificio);
            this.Controls.Add(this.ListBoxEdificios);
            this.Controls.Add(this.TboxOrigen);
            this.Controls.Add(this.LblOrigen);
            this.Controls.Add(this.TboxDistancia);
            this.Controls.Add(this.TboxEdificio);
            this.Controls.Add(this.LblDistancia);
            this.Controls.Add(this.LblEdificio);
            this.Name = "GraFo";
            this.Text = "GraFo";
            this.Load += new System.EventHandler(this.GraFo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEdificio;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.TextBox TboxEdificio;
        private System.Windows.Forms.TextBox TboxDistancia;
        private System.Windows.Forms.Label LblOrigen;
        private System.Windows.Forms.TextBox TboxOrigen;
        private System.Windows.Forms.ListBox ListBoxEdificios;
        private System.Windows.Forms.Button BtnAgregarEdificio;
        private System.Windows.Forms.Button BtnAggConexion;
        private System.Windows.Forms.Button BtnMostrarConexiones;
        private System.Windows.Forms.Button BtnRutaMasCorta;
        private System.Windows.Forms.Button BtnValidarConexidad;
        private System.Windows.Forms.TextBox TboxDestino;
        private System.Windows.Forms.Label label1;
    }
}