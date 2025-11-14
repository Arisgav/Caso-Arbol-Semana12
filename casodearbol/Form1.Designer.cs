namespace casodearbol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TvArbol = new System.Windows.Forms.TreeView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.TBox = new System.Windows.Forms.TextBox();
            this.BtnInsetar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnContar = new System.Windows.Forms.Button();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TvArbol
            // 
            this.TvArbol.Location = new System.Drawing.Point(130, 96);
            this.TvArbol.Name = "TvArbol";
            this.TvArbol.Size = new System.Drawing.Size(263, 228);
            this.TvArbol.TabIndex = 0;
            this.TvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvArbol_AfterSelect);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(347, 33);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(164, 40);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(41, 47);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(154, 13);
            this.Lbl1.TabIndex = 2;
            this.Lbl1.Text = "metelo justo aqui que es ancho";
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(201, 40);
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(132, 20);
            this.TBox.TabIndex = 3;
            // 
            // BtnInsetar
            // 
            this.BtnInsetar.Location = new System.Drawing.Point(436, 96);
            this.BtnInsetar.Name = "BtnInsetar";
            this.BtnInsetar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsetar.TabIndex = 4;
            this.BtnInsetar.Text = "Insertar";
            this.BtnInsetar.UseVisualStyleBackColor = true;
            this.BtnInsetar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(436, 181);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(436, 139);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(75, 23);
            this.BtnContar.TabIndex = 6;
            this.BtnContar.Text = "Contar";
            this.BtnContar.UseVisualStyleBackColor = true;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(517, 144);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(16, 13);
            this.Lbl2.TabIndex = 7;
            this.Lbl2.Text = ":0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.BtnContar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnInsetar);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TvArbol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TvArbol;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox TBox;
        private System.Windows.Forms.Button BtnInsetar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnContar;
        private System.Windows.Forms.Label Lbl2;
    }
}

