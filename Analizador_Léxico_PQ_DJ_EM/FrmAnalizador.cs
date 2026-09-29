using Analizador_Léxico_PQ_DJ_EM.Clases;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Analizador_Léxico_PQ_DJ_EM
{
    public partial class FrmAnalizador : Form
    {
        private LecturaAnalizador motor;

        public FrmAnalizador()
        {
            InitializeComponent();
            motor = new LecturaAnalizador();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de código/texto (*.txt;*.cs)|*.txt;*.cs|Todos los archivos (*.*)|*.*",
                Title = "Seleccionar archivo de código fuente"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtbTexto.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnAnalizar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbTexto.Text))
            {
                MessageBox.Show("Ingrese o cargue texto para analizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatosCompartidos.Motor.AnalizarTexto(rtbTexto.Text);

            dgvResultado.DataSource = null;
            dgvResultado.DataSource = new BindingList<tbResultados>(DatosCompartidos.Motor.ObtenerTokens());

            dgvError.DataSource = null;
            dgvError.DataSource = new BindingList<tbError>(DatosCompartidos.Motor.ObtenerErrores());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rtbTexto.Clear();
            dgvResultado.DataSource = null;
            dgvError.DataSource = null;
        }

        public TablaDeSimbolos ObtenerTablaSimbolos()
        {
            return motor.ObtenerTablaSimbolos();
        }

        private void lbltokens_Click(object sender, EventArgs e)
        {
            FrmTokens FrmTokens = new FrmTokens();
            this.Hide();
            FrmTokens.Show();
        }
    }
}
