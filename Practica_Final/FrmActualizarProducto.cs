using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Final
{
    public partial class FrmActualizarProducto : Form
    {
        public FrmActualizarProducto()
        {
            InitializeComponent();

            // 1. Definimos un tamaño Grande (Ancho, Alto)
            this.Size = new Size(1250, 800);

            // 2. Bloqueamos para que el usuario no lo ponga pequeño
            this.MinimumSize = new Size(1250, 800);

            // 3. Centramos en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // 4. Evitamos que se abra en pantalla completa (opcional)
            this.WindowState = FormWindowState.Normal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // Cuando el usuario hace clic para escribir

            {
                if (txtBusqueda.Text == "Ingrese ID o Nombre...")
                {
                    txtBusqueda.Text = ""; // Borramos el texto sugerido
                    txtBusqueda.ForeColor = Color.Black; // Ponemos el texto en negro para escribir
                }
            }
        }
    

        // Cuando el usuario sale del cuadro sin escribir nada
        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                txtBusqueda.Text = "Ingrese ID o Nombre..."; // Ponemos la sugerencia otra vez
                txtBusqueda.ForeColor = Color.Gray; // Lo ponemos gris de nuevo
            }
        }

        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {

        }
    }
    }

