using System;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TvArbol
            // 
            this.TvArbol.Location = new System.Drawing.Point(70, 80);
            this.TvArbol.Name = "TvArbol";
            this.TvArbol.Size = new System.Drawing.Size(263, 228);
            this.TvArbol.TabIndex = 0;
            this.TvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvArbol_AfterSelect);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(347, 33);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(84, 40);
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
            this.BtnInsetar.Location = new System.Drawing.Point(356, 110);
            this.BtnInsetar.Name = "BtnInsetar";
            this.BtnInsetar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsetar.TabIndex = 4;
            this.BtnInsetar.Text = "Insertar";
            this.BtnInsetar.UseVisualStyleBackColor = true;
            this.BtnInsetar.Click += new System.EventHandler(this.BtnInsetar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(356, 178);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(356, 149);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(75, 23);
            this.BtnContar.TabIndex = 6;
            this.BtnContar.Text = "Contar";
            this.BtnContar.UseVisualStyleBackColor = true;
            this.BtnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafoToolStripMenuItem1});
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.grafoToolStripMenuItem.Text = "Opcion";
            this.grafoToolStripMenuItem.Click += new System.EventHandler(this.grafoToolStripMenuItem_Click);
            // 
            // grafoToolStripMenuItem1
            // 
            this.grafoToolStripMenuItem1.Name = "grafoToolStripMenuItem1";
            this.grafoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.grafoToolStripMenuItem1.Text = "Grafo";
            this.grafoToolStripMenuItem1.Click += new System.EventHandler(this.grafoToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.BtnContar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnInsetar);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TvArbol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private EventHandler button1_Click;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem1;
    }
}

