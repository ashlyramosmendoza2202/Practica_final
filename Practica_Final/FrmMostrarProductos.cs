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
    public partial class FrmMostrarProductos : Form
    {
        public FrmMostrarProductos()
        {
            InitializeComponent();
        }

        private void FrmMostrarProductos_Load(object sender, EventArgs e)
        {
             dgvProductos.DataSource = null;
            dgvProductos.DataSource = Datos.listaProductos;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;

        }
    }
    }

