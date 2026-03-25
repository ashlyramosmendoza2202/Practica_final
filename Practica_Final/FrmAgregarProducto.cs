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
            try
            {
                int id = int.Parse(txtld.Text);

                // Validar ID único

                if (Datos.listaProductos.Any(producto => producto.Id == id))
                {
                    MessageBox.Show("El ID ya existe");
                    return;
                }

                string nombre = txtNombre.Text;
                string categoria = cmbCategoria.Text;
                string necesidad = cmbNecesidad.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);
                int cantidadMinima = int.Parse(txtCantidadMinima.Text);

                // Calcular ITBIS

                decimal itbis = 0;

                if (necesidad == "Primera") itbis = precio * 0.08m;
                else if (necesidad == "Segunda") itbis = precio * 0.14m;
                else if (necesidad == "Tercera") itbis = precio * 0.18m;

                // Calcular estado

                string estado = "";

                if (cantidad == 0)
                    estado = "Sin existencia";
                else if (cantidad <= cantidadMinima)
                    estado = "Próximo a terminar";
                else
                    estado = "Disponible";

                // Crear producto
                Producto p = new Producto()
                {
                    Id = id,
                    Nombre = nombre,
                    Categoria = categoria,
                    Necesidad = necesidad,
                    Cantidad = cantidad,
                    Precio = precio,
                    ITBIS = itbis,
                    CantidadMinima = cantidadMinima,
                    Estado = estado
                };

                // Guardar en la lista
                Datos.listaProductos.Add(p);

                MessageBox.Show("Producto agregado correctamente");

                // Limpiar campos
                txtld.Clear();
                txtNombre.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
                txtCantidadMinima.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

        private void txtNombre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
