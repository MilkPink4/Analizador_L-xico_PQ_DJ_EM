using Analizador_Léxico_PQ_DJ_EM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace Analizador_Léxico_PQ_DJ_EM
{
    public partial class FrmTokens : Form
    {
        public FrmTokens()
        {
            InitializeComponent();
        }

        private void FrmTokens_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ActualizarGrid(IEnumerable<tbResultados> fuenteDatos = null)
        {
            dgvTablaSimbolos.DataSource = null;
            dgvTablaSimbolos.AutoGenerateColumns = true;

            var datos = fuenteDatos ?? DatosCompartidos.Motor.ObtenerTokens();

            var datosOrdenados = datos.OrderBy(t => t.Identificador).ToList();

            dgvTablaSimbolos.DataSource = new BindingList<tbResultados>(datosOrdenados);
            dgvTablaSimbolos.AutoResizeColumns();
        }

        private void btnAnalizar_Click(object sender, System.EventArgs e)
        {
            txtToken.Clear();
            txtSimbolo.Clear();
            ActualizarGrid();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            string filtroToken = txtToken.Text.Trim().ToLower();
            string filtroSimbolo = txtSimbolo.Text.Trim().ToLower();

            var tokensGlobales = DatosCompartidos.Motor.ObtenerTokens();

            var resultados = tokensGlobales.Where(t =>
                (string.IsNullOrEmpty(filtroToken) || (t.TipoToken != null && t.TipoToken.ToLower().Contains(filtroToken))) &&
                (string.IsNullOrEmpty(filtroSimbolo) || (t.Identificador != null && t.Identificador.ToLower().Contains(filtroSimbolo)))
            ).ToList();

            ActualizarGrid(resultados);
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            string simboloAEliminar = txtSimbolo.Text.Trim();

            if (string.IsNullOrEmpty(simboloAEliminar))
            {
                MessageBox.Show("Ingrese el nombre del símbolo a eliminar en el campo 'Simbolo'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var listaTokens = DatosCompartidos.Motor.ObtenerTokens();
            int eliminados = listaTokens.RemoveAll(t => t.Identificador != null && t.Identificador.Equals(simboloAEliminar, StringComparison.OrdinalIgnoreCase));

            if (eliminados > 0)
            {
                MessageBox.Show($"Se eliminó '{simboloAEliminar}' ({eliminados} coincidencia(s)).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSimbolo.Clear();
                ActualizarGrid();
            }
            else
            {
                MessageBox.Show($"No se encontró ningún token con el nombre '{simboloAEliminar}'.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblAnalizador_Click(object sender, EventArgs e)
        {
            FrmAnalizador FrmAnalizador = new FrmAnalizador();
            this.Hide();
            FrmAnalizador.Show();
        }
    }
}
