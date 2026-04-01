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
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            {
                Producto p = new Producto();

                p.Id = int.Parse(txtld.Text);
                p.Nombre = txtNombre.Text;
                p.Categoria = cmbCategoria.Text;
                p.Necesidad = cmbNecesidad.Text;
                p.Cantidad = int.Parse(txtCantidadMinima.Text);
                p.PrecioPorUnidad = decimal.Parse(txtPrecioPorUnidad.Text);
                p.ITBIS = decimal.Parse(txtITBIS.Text);
                p.CantidadMinima = int.Parse(txtCantidadMinima.Text);
                p.Estado = txtEstado.Text;

                Datos.listaProductos.Add(p);

                MessageBox.Show("Producto agregado 🔥");

                txtld.Clear();
                txtNombre.Clear();
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        