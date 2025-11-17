using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casodearbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Clase nodo (si la necesitás luego para estructuras)
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

        // Nodo seleccionado en el TreeView
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

        // AGREGAR NODO (RAÍZ E HIJO)
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBox.Text))
            {
                if (nodoSeleccionado != null)
                {
                    // Agregar como hijo del nodo seleccionado
                    nodoSeleccionado.Nodes.Add(TBox.Text);
                    nodoSeleccionado.Expand();
                }
                else
                {
                    // Agregar como nodo raíz
                    TvArbol.Nodes.Add(TBox.Text);
                }

                TBox.Clear();
            }
        }

        // CORRECCIÓN: obtener nodo seleccionado
        private void TvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nodoSeleccionado = e.Node;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // BOTÓN INSERTAR (agregar hijo al seleccionado)
        private void BtnInsetar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBox.Text))
                return;

            if (nodoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un nodo primero.");
                return;
            }

            nodoSeleccionado.Nodes.Add(TBox.Text);
            nodoSeleccionado.Expand();
            TBox.Clear();
        }

        // FUNCIÓN RECURSIVA PARA CONTAR NODOS
        private int ContarNodos(TreeNodeCollection nodos)
        {
            int total = 0;

            foreach (TreeNode n in nodos)
            {
                total++;
                total += ContarNodos(n.Nodes);
            }

            return total;
        }

        // BOTÓN CONTAR
        private void BtnContar_Click(object sender, EventArgs e)
        {
            int total = ContarNodos(TvArbol.Nodes);
            MessageBox.Show("Total de nodos: " + total);
        }

        // FUNCIÓN BUSCAR
        private TreeNode BuscarNodo(TreeNodeCollection nodos, string texto)
        {
            foreach (TreeNode n in nodos)
            {
                if (n.Text == texto)
                    return n;

                TreeNode encontrado = BuscarNodo(n.Nodes, texto);
                if (encontrado != null)
                    return encontrado;
            }

            return null;
        }

        // BOTÓN BUSCAR
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBox.Text))
                return;

            TreeNode encontrado = BuscarNodo(TvArbol.Nodes, TBox.Text);

            if (encontrado != null)
            {
                TvArbol.SelectedNode = encontrado;
                encontrado.Expand();
            }
            else
            {
                MessageBox.Show("No se encontró el nodo.");
            }

            TBox.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grafoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GraFo fg = new GraFo();
            fg.Show();
        }
    }
}
