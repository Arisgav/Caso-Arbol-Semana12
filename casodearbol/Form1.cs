using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace casodearbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Nodo
        {
            public int Valor;
            public Nodo Izquierdo;
            public Nodo Derecho;

            public Nodo(int valor)
            {
                Valor = valor;
                Izquierdo = null;
                Derecho = null;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBox.Text))
            {
                TvArbol.Nodes.Add(TBox.Text);
                TBox.Clear();
            }
        }

        private void TvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
