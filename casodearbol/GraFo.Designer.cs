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
            this.TboxEdificio2 = new System.Windows.Forms.TextBox();
            this.LblOrigen = new System.Windows.Forms.Label();
            this.TboxDistanciaEntreEdificios = new System.Windows.Forms.TextBox();
            this.ListBoxEdificios = new System.Windows.Forms.ListBox();
            this.BtnAgregarEdificio = new System.Windows.Forms.Button();
            this.BtnAggConexion = new System.Windows.Forms.Button();
            this.BtnMostrarConexiones = new System.Windows.Forms.Button();
            this.BtnRutaMasCorta = new System.Windows.Forms.Button();
            this.BtnValidarConexidad = new System.Windows.Forms.Button();
            this.TboxEdificio1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarEdificio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblEdificio
            // 
            this.LblEdificio.AutoSize = true;
            this.LblEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdificio.Location = new System.Drawing.Point(205, 32);
            this.LblEdificio.Name = "LblEdificio";
            this.LblEdificio.Size = new System.Drawing.Size(164, 25);
            this.LblEdificio.TabIndex = 0;
            this.LblEdificio.Text = "Agregar Edificio";
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistancia.Location = new System.Drawing.Point(205, 209);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(241, 25);
            this.LblDistancia.TabIndex = 1;
            this.LblDistancia.Text = "Distancia entre edificios";
            this.LblDistancia.Click += new System.EventHandler(this.label1_Click);
            // 
            // TboxEdificio
            // 
            this.TboxEdificio.Location = new System.Drawing.Point(190, 71);
            this.TboxEdificio.Name = "TboxEdificio";
            this.TboxEdificio.Size = new System.Drawing.Size(215, 20);
            this.TboxEdificio.TabIndex = 2;
            this.TboxEdificio.TextChanged += new System.EventHandler(this.TboxEdificio_TextChanged);
            // 
            // TboxEdificio2
            // 
            this.TboxEdificio2.Location = new System.Drawing.Point(337, 176);
            this.TboxEdificio2.Name = "TboxEdificio2";
            this.TboxEdificio2.Size = new System.Drawing.Size(128, 20);
            this.TboxEdificio2.TabIndex = 5;
            // 
            // LblOrigen
            // 
            this.LblOrigen.AutoSize = true;
            this.LblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrigen.Location = new System.Drawing.Point(7, 333);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(103, 33);
            this.LblOrigen.TabIndex = 6;
            this.LblOrigen.Text = "Origen";
            // 
            // TboxDistanciaEntreEdificios
            // 
            this.TboxDistanciaEntreEdificios.Location = new System.Drawing.Point(269, 248);
            this.TboxDistanciaEntreEdificios.Name = "TboxDistanciaEntreEdificios";
            this.TboxDistanciaEntreEdificios.Size = new System.Drawing.Size(100, 20);
            this.TboxDistanciaEntreEdificios.TabIndex = 7;
            this.TboxDistanciaEntreEdificios.TextChanged += new System.EventHandler(this.TboxOrigen_TextChanged);
            // 
            // ListBoxEdificios
            // 
            this.ListBoxEdificios.FormattingEnabled = true;
            this.ListBoxEdificios.Location = new System.Drawing.Point(633, 50);
            this.ListBoxEdificios.Name = "ListBoxEdificios";
            this.ListBoxEdificios.Size = new System.Drawing.Size(361, 316);
            this.ListBoxEdificios.TabIndex = 8;
            // 
            // BtnAgregarEdificio
            // 
            this.BtnAgregarEdificio.Location = new System.Drawing.Point(411, 71);
            this.BtnAgregarEdificio.Name = "BtnAgregarEdificio";
            this.BtnAgregarEdificio.Size = new System.Drawing.Size(107, 28);
            this.BtnAgregarEdificio.TabIndex = 9;
            this.BtnAgregarEdificio.Text = "Agregar ";
            this.BtnAgregarEdificio.UseVisualStyleBackColor = true;
            this.BtnAgregarEdificio.Click += new System.EventHandler(this.BtnAgregarEdificio_Click);
            // 
            // BtnAggConexion
            // 
            this.BtnAggConexion.Location = new System.Drawing.Point(358, 310);
            this.BtnAggConexion.Name = "BtnAggConexion";
            this.BtnAggConexion.Size = new System.Drawing.Size(75, 66);
            this.BtnAggConexion.TabIndex = 10;
            this.BtnAggConexion.Text = "Agregar Conexion";
            this.BtnAggConexion.UseVisualStyleBackColor = true;
            this.BtnAggConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // BtnMostrarConexiones
            // 
            this.BtnMostrarConexiones.Location = new System.Drawing.Point(504, 327);
            this.BtnMostrarConexiones.Name = "BtnMostrarConexiones";
            this.BtnMostrarConexiones.Size = new System.Drawing.Size(75, 66);
            this.BtnMostrarConexiones.TabIndex = 11;
            this.BtnMostrarConexiones.Text = "Mostrar Conexiones";
            this.BtnMostrarConexiones.UseVisualStyleBackColor = true;
            this.BtnMostrarConexiones.Click += new System.EventHandler(this.BtnMostrarC_Click);
            // 
            // BtnRutaMasCorta
            // 
            this.BtnRutaMasCorta.Location = new System.Drawing.Point(231, 319);
            this.BtnRutaMasCorta.Name = "BtnRutaMasCorta";
            this.BtnRutaMasCorta.Size = new System.Drawing.Size(138, 54);
            this.BtnRutaMasCorta.TabIndex = 12;
            this.BtnRutaMasCorta.Text = "Ruta Mas corta";
            this.BtnRutaMasCorta.UseVisualStyleBackColor = true;
            // 
            // BtnValidarConexidad
            // 
            this.BtnValidarConexidad.Location = new System.Drawing.Point(411, 310);
            this.BtnValidarConexidad.Name = "BtnValidarConexidad";
            this.BtnValidarConexidad.Size = new System.Drawing.Size(81, 63);
            this.BtnValidarConexidad.TabIndex = 13;
            this.BtnValidarConexidad.Text = "Validar Conexidad";
            this.BtnValidarConexidad.UseVisualStyleBackColor = true;
            // 
            // TboxEdificio1
            // 
            this.TboxEdificio1.Location = new System.Drawing.Point(190, 176);
            this.TboxEdificio1.Name = "TboxEdificio1";
            this.TboxEdificio1.Size = new System.Drawing.Size(129, 20);
            this.TboxEdificio1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Edificios";
            // 
            // BtnEliminarEdificio
            // 
            this.BtnEliminarEdificio.Location = new System.Drawing.Point(520, 71);
            this.BtnEliminarEdificio.Name = "BtnEliminarEdificio";
            this.BtnEliminarEdificio.Size = new System.Drawing.Size(107, 28);
            this.BtnEliminarEdificio.TabIndex = 16;
            this.BtnEliminarEdificio.Text = "Eliminar Edificio";
            this.BtnEliminarEdificio.UseVisualStyleBackColor = true;
            this.BtnEliminarEdificio.Click += new System.EventHandler(this.BtnEliminarEdificio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEliminarEdificio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TboxEdificio1);
            this.groupBox1.Controls.Add(this.BtnValidarConexidad);
            this.groupBox1.Controls.Add(this.BtnRutaMasCorta);
            this.groupBox1.Controls.Add(this.BtnAggConexion);
            this.groupBox1.Controls.Add(this.BtnAgregarEdificio);
            this.groupBox1.Controls.Add(this.ListBoxEdificios);
            this.groupBox1.Controls.Add(this.TboxDistanciaEntreEdificios);
            this.groupBox1.Controls.Add(this.LblOrigen);
            this.groupBox1.Controls.Add(this.TboxEdificio2);
            this.groupBox1.Controls.Add(this.TboxEdificio);
            this.groupBox1.Controls.Add(this.LblDistancia);
            this.groupBox1.Controls.Add(this.LblEdificio);
            this.groupBox1.Location = new System.Drawing.Point(5, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 378);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // GraFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnMostrarConexiones);
            this.Name = "GraFo";
            this.Text = "GraFo";
            this.Load += new System.EventHandler(this.GraFo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblEdificio;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.TextBox TboxEdificio;
        private System.Windows.Forms.TextBox TboxEdificio2;
        private System.Windows.Forms.Label LblOrigen;
        private System.Windows.Forms.TextBox TboxDistanciaEntreEdificios;
        private System.Windows.Forms.ListBox ListBoxEdificios;
        private System.Windows.Forms.Button BtnAgregarEdificio;
        private System.Windows.Forms.Button BtnAggConexion;
        private System.Windows.Forms.Button BtnMostrarConexiones;
        private System.Windows.Forms.Button BtnRutaMasCorta;
        private System.Windows.Forms.Button BtnValidarConexidad;
        private System.Windows.Forms.TextBox TboxEdificio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarEdificio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}