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

        // Clase nodo (opcional para estructuras más avanzadas)
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

        // Nodo actualmente seleccionado en TreeView
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

        // ==================== BOTÓN AGREGAR ====================
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBox.Text))
            {
                // Agregar siempre como nodo raíz
                TvArbol.Nodes.Add(TBox.Text);

                // Limpiar selección
                TvArbol.SelectedNode = null;
                nodoSeleccionado = null;

                TBox.Clear();
            }
        }

        private void TvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nodoSeleccionado = e.Node;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ==================== BOTÓN INSERTAR ====================
        private void BtnInsetar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBox.Text))
                return;

            if (nodoSeleccionado == null)
            {
                MessageBox.Show("Selecciona una rama para agregar una subrama.");
                return;
            }

            nodoSeleccionado.Nodes.Add(TBox.Text);
            nodoSeleccionado.Expand();
            TBox.Clear();
        }

        // ==================== CONTAR NODOS ====================
        private int ContarNodos(TreeNodeCollection nodos)
        {
            int total = 0;

            foreach (TreeNode n in nodos)
            {
                total++; // cuenta este nodo
                total += ContarNodos(n.Nodes); // cuenta los hijos
            }

            return total;
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            int total = ContarNodos(TvArbol.Nodes);
            MessageBox.Show("Total de nodos: " + total);
        }

        // ==================== FUNCIÓN BUSCAR ====================
        private TreeNode BuscarNodo(TreeNodeCollection nodos, string texto)
        {
            foreach (TreeNode n in nodos)
            {
                if (n.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
                    return n;

                TreeNode encontrado = BuscarNodo(n.Nodes, texto);
                if (encontrado != null)
                    return encontrado;
            }

            return null;
        }

        // Función para generar ruta legible
        private string ObtenerRutaLegible(TreeNode nodo)
        {
            if (nodo == null) return "";
            string ruta = nodo.Text;
            TreeNode padre = nodo.Parent;

            while (padre != null)
            {
                ruta = padre.Text + " > " + ruta;
                padre = padre.Parent;
            }

            return ruta;
        }

        // ==================== BOTÓN BUSCAR ====================
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = TBox.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            TreeNode encontrado = BuscarNodo(TvArbol.Nodes, texto);

            if (encontrado != null)
            {
                TvArbol.SelectedNode = encontrado;
                encontrado.Expand();
                encontrado.EnsureVisible();

                string ruta = ObtenerRutaLegible(encontrado);
                MessageBox.Show($"Nodo '{texto}' encontrado en la ruta:\n{ruta}");
            }
            else
            {
                MessageBox.Show($"No se encontró el nodo '{texto}' en el árbol.");
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

        private void Lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
