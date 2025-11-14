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
            this.SuspendLayout();
            // 
            // TvArbol
            // 
            this.TvArbol.Location = new System.Drawing.Point(130, 96);
            this.TvArbol.Name = "TvArbol";
            this.TvArbol.Size = new System.Drawing.Size(263, 228);
            this.TvArbol.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

