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
            this.BackColor = Color.White;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Datos.listaProductos;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Datos.listaProductos;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;

            // 🔥 QUITAR ESTILO FEO
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.RowHeadersVisible = false;

            // 🎨 HEADER PRO
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(108, 99, 255); // morado bonito
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(108, 99, 255);
            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // 🎨 FILAS
            dgvProductos.DefaultCellStyle.BackColor = Color.White;
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);

            // ✨ SELECCIÓN
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(108, 99, 255);
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvProductos.GridColor = Color.LightGray;
        }
    }
}
