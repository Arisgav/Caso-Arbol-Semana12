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
        TreeNode nodoSeleccionado;
        private TreeNode CrearNodoTree(Nodo nodo)
        {
            TreeNode tn = new TreeNode(nodo.Valor.ToString());

            if (nodo.Izquierdo != null)
                tn.Nodes.Add(CrearNodoTree(nodo.Izquierdo));

            if (nodo.Derecho != null)
                tn.Nodes.Add(CrearNodoTree(nodo.Derecho));

            return tn;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBox.Text))
            {
                if (nodoSeleccionado != null)
                {
                    // Agregar como hijo del nodo seleccionado
                    nodoSeleccionado.Nodes.Add(TBox.Text);
                    nodoSeleccionado.Expand(); // para que se vea
                }
                else
                {
                    // Si no hay nodo seleccionado, se agrega como un nodo raíz
                    TvArbol.Nodes.Add(TBox.Text);
                }

                TBox.Clear();
            }
        }

        private void TvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TvArbol.AfterSelect += TvArbol_AfterSelect;
        }
    }
}
