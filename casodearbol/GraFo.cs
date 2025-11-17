using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace casodearbol
{
    public partial class GraFo : Form
    {
        Dictionary<string, List<(string destino, int distancia)>> grafo =
            new Dictionary<string, List<(string destino, int distancia)>>();

        public GraFo()
        {
            InitializeComponent();
        }

        private void BtnAgregarEdificio_Click(object sender, EventArgs e)
        {
            string edificio = TboxEdificio.Text.Trim();

            if (edificio == "")
            {
                MessageBox.Show("Ingrese el nombre del edificio.");
                return;
            }

            if (!grafo.ContainsKey(edificio))
            {
                grafo.Add(edificio, new List<(string, int)>());
                ListBoxEdificios.Items.Add(edificio);
                MessageBox.Show("Edificio agregado correctamente.");
            }
            else
            {
                MessageBox.Show("Ese edificio ya existe.");
            }

            TboxEdificio.Clear();
        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            string origen = TboxOrigen.Text.Trim();
            string destino = TboxDestino.Text.Trim();

            if (!int.TryParse(TboxDistancia.Text, out int distancia) || distancia <= 0)
            {
                MessageBox.Show("Ingrese una distancia válida (número mayor a 0).");
                return;
            }

            if (origen == "" || destino == "")
            {
                MessageBox.Show("Ingrese origen y destino.");
                return;
            }

            if (!grafo.ContainsKey(origen) || !grafo.ContainsKey(destino))
            {
                MessageBox.Show("Ambos edificios deben existir en el grafo.");
                return;
            }

            if (origen == destino)
            {
                MessageBox.Show("No se puede conectar un edificio consigo mismo.");
                return;
            }

            // Evitar duplicados
            if (grafo[origen].Any(x => x.destino == destino))
            {
                MessageBox.Show("Ya existe una conexión entre esos edificios.");
                return;
            }

            // Agregar conexión bidireccional
            grafo[origen].Add((destino, distancia));
            grafo[destino].Add((origen, distancia));

            MessageBox.Show($"Conexión agregada: {origen} <-> {destino} ({distancia})");

            TboxOrigen.Clear();
            TboxDestino.Clear();
            TboxDistancia.Clear();
        }

        private void BtnMostrarC_Click(object sender, EventArgs e)
        {
            if (grafo.Count == 0)
            {
                MessageBox.Show("No hay edificios en el grafo.");
                return;
            }

            string conexiones = "CONEXIONES DEL GRAFO:\n\n";

            foreach (var edificio in grafo)
            {
                conexiones += $"{edificio.Key}:\n";

                if (edificio.Value.Count == 0)
                {
                    conexiones += "  Sin conexiones\n";
                }
                else
                {
                    foreach (var conexion in edificio.Value)
                    {
                        conexiones += $"  -> {conexion.destino} ({conexion.distancia})\n";
                    }
                }
                conexiones += "\n";
            }

            MessageBox.Show(conexiones, "Conexiones del Parque");
        }

        private void BtnValidarConexidad_Click(object sender, EventArgs e)
        {
            if (grafo.Count == 0)
            {
                MessageBox.Show("El grafo está vacío.");
                return;
            }

            if (EsGrafoConexo())
            {
                MessageBox.Show("✅ El grafo ES CONEXO - Todos los edificios están conectados.");
            }
            else
            {
                MessageBox.Show("❌ El grafo NO ES CONEXO - Hay edificios aislados.");
            }
        }

        private bool EsGrafoConexo()
        {
            var visitados = new HashSet<string>();
            var cola = new Queue<string>();

            var inicio = grafo.Keys.First();
            visitados.Add(inicio);
            cola.Enqueue(inicio);

            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();

                foreach (var vecino in grafo[actual])
                {
                    if (visitados.Add(vecino.destino))
                        cola.Enqueue(vecino.destino);
                }
            }

            return visitados.Count == grafo.Count;
        }

        private void BtnRutaMasCorta_Click(object sender, EventArgs e)
        {
            string origen = TboxOrigen.Text.Trim();
            string destino = TboxDestino.Text.Trim();

            if (origen == "" || destino == "")
            {
                MessageBox.Show("Ingrese origen y destino para calcular la ruta.");
                return;
            }

            if (!grafo.ContainsKey(origen) || !grafo.ContainsKey(destino))
            {
                MessageBox.Show("Ambos edificios deben existir en el grafo.");
                return;
            }

            var (distancia, ruta) = Dijkstra(origen, destino);

            if (distancia == int.MaxValue)
            {
                MessageBox.Show($"No hay ruta posible entre {origen} y {destino}.");
                return;
            }

            MessageBox.Show(
                $"Ruta más corta: {string.Join(" -> ", ruta)}\nDistancia total: {distancia}",
                "Ruta Calculada"
            );
        }

        private (int distancia, List<string> ruta) Dijkstra(string origen, string destino)
        {
            var dist = new Dictionary<string, int>();
            var prev = new Dictionary<string, string>();
            var pendientes = new HashSet<string>(grafo.Keys);

            foreach (var nodo in grafo.Keys)
            {
                dist[nodo] = int.MaxValue;
                prev[nodo] = null;
            }

            dist[origen] = 0;

            while (pendientes.Count > 0)
            {
                string actual = pendientes
                    .OrderBy(n => dist[n])
                    .FirstOrDefault();

                if (actual == null || dist[actual] == int.MaxValue)
                    break;

                pendientes.Remove(actual);

                if (actual == destino)
                    break;

                foreach (var vecino in grafo[actual])
                {
                    if (!pendientes.Contains(vecino.destino))
                        continue;

                    int nuevaDist = dist[actual] + vecino.distancia;

                    if (nuevaDist < dist[vecino.destino])
                    {
                        dist[vecino.destino] = nuevaDist;
                        prev[vecino.destino] = actual;
                    }
                }
            }

            if (dist[destino] == int.MaxValue)
                return (int.MaxValue, new List<string>());

            // Reconstruir ruta
            List<string> ruta = new List<string>();
            string actualRuta = destino;

            while (actualRuta != null)
            {
                ruta.Insert(0, actualRuta);
                actualRuta = prev[actualRuta];
            }

            return (dist[destino], ruta);
        }

        // Eventos vacíos válidos que sí pueden existir
        private void label1_Click(object sender, EventArgs e) { }
        private void TboxOrigen_TextChanged(object sender, EventArgs e) { }
        private void TboxEdificio_TextChanged(object sender, EventArgs e) { }
        private void GraFo_Load(object sender, EventArgs e) { }
    }
}
