using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica_Final
{
    public partial class FrmActualizarProducto : Form
    {
        public FrmActualizarProducto()
        {
            InitializeComponent();

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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            // Si el cuadro está vacío, no busques nada y LIMPIA el nombre.
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                txtNombre.Text = "";
                return;
            }

            // Elimina el código inaccesible y usa la lista correcta
            if (txtBusqueda.Text == "Ingrese ID o nombre...")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }

            var p = Datos.listaProductos.FirstOrDefault(x => x.Id.ToString() == txtBusqueda.Text ||
                 x.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower()));

            if (p != null)
            {
                txtID.Text = p.Id.ToString();
                txtNombre.Text = p.Nombre;
                cmbCategoria.Text = p.Categoria;
                numCantidad.Value = p.Cantidad;
                txtPrecio.Text = p.PrecioPorUnidad.ToString();
                txtMinima.Text = p.CantidadMinima.ToString();
                cmbNecesidad.Text = p.Necesidad;
                txtITBIS.Text = p.ITBIS.ToString();
                txtEstado.Text = p.Estado;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            {
                // Buscamos el producto por el ID que está en el cuadro txtID
                var p = Datos.listaProductos.FirstOrDefault(x => x.Id.ToString() == txtID.Text);

                if (p != null)
                {
                    // Actualizamos los datos en la lista
                    p.Nombre = txtNombre.Text;
                    p.Categoria = cmbCategoria.Text;
                    p.Cantidad = (int)numCantidad.Value;
                    p.PrecioPorUnidad = decimal.Parse(txtPrecio.Text);
                    p.CantidadMinima = int.Parse(txtMinima.Text);
                    p.Necesidad = cmbNecesidad.Text;

                    // Aquí puedes copiar tu lógica de ITBIS de 'Agregar' para que se recalcule

                    MessageBox.Show("¡Producto actualizado! Cierra esta ventana y dale a 'Mostrar' en la tabla.");
                    this.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // Buscamos el producto
            var p = Datos.listaProductos.FirstOrDefault(x => x.Id.ToString() == txtID.Text);

            if (p != null)
            {
                // 1. Lo borramos de la lista
                Datos.listaProductos.Remove(p);

                MessageBox.Show("Producto eliminado correctamente.");

                // 2. IMPORTANTE: Antes de cerrar, 'limpiamos' el foco
                this.DialogResult = DialogResult.OK;
                this.Close();
                {


                }
            }
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Ingrese ID o nombre...")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtPrecio.Text, out decimal precio) &&
                int.TryParse(numCantidad.Text, out int cant) &&
                int.TryParse(txtMinima.Text, out int min))
            {

                decimal porcentaje = 0;
                if (cmbNecesidad.Text == "Primera") porcentaje = 0.08m;
                else if (cmbNecesidad.Text == "Segunda") porcentaje = 0.14m;
                else if (cmbNecesidad.Text == "Tercera") porcentaje = 0.18m;

                decimal elItbis = precio * porcentaje;
                txtITBIS.Text = elItbis.ToString("N2");


                if (cant == 0) txtEstado.Text = "Sin existencia";
                else if (cant <= min) txtEstado.Text = "Próximo a terminar";
                else txtEstado.Text = "Disponible";
            }
        }

        private void txtMinima_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtPrecio.Text, out decimal precio) &&
                int.TryParse(numCantidad.Text, out int cant) &&
                int.TryParse(txtMinima.Text, out int min))
            {

                decimal porcentaje = 0;
                if (cmbNecesidad.Text == "Primera") porcentaje = 0.08m;
                else if (cmbNecesidad.Text == "Segunda") porcentaje = 0.14m;
                else if (cmbNecesidad.Text == "Tercera") porcentaje = 0.18m;

                decimal elItbis = precio * porcentaje;
                txtITBIS.Text = elItbis.ToString("N2");

                if (cant == 0) txtEstado.Text = "Sin existencia";
                else if (cant <= min) txtEstado.Text = "Próximo a terminar";
                else txtEstado.Text = "Disponible";
            }
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, out decimal precio) &&
                int.TryParse(numCantidad.Text, out int cant) &&
                int.TryParse(txtMinima.Text, out int min))
            {

                decimal porcentaje = 0;
                if (cmbNecesidad.Text == "Primera") porcentaje = 0.08m;
                else if (cmbNecesidad.Text == "Segunda") porcentaje = 0.14m;
                else if (cmbNecesidad.Text == "Tercera") porcentaje = 0.18m;

                decimal elItbis = precio * porcentaje;
                txtITBIS.Text = elItbis.ToString("N2");

                if (cant == 0) txtEstado.Text = "Sin existencia";
                else if (cant <= min) txtEstado.Text = "Próximo a terminar";
                else txtEstado.Text = "Disponible";
            }
        }

        private void cmbNecesidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, out decimal precio) &&
               int.TryParse(numCantidad.Text, out int cant) &&
               int.TryParse(txtMinima.Text, out int min))
            {

                decimal porcentaje = 0;
                if (cmbNecesidad.Text == "Primera") porcentaje = 0.08m;
                else if (cmbNecesidad.Text == "Segunda") porcentaje = 0.14m;
                else if (cmbNecesidad.Text == "Tercera") porcentaje = 0.18m;

                decimal elItbis = precio * porcentaje;
                txtITBIS.Text = elItbis.ToString("N2");

                if (cant == 0) txtEstado.Text = "Sin existencia";
                else if (cant <= min) txtEstado.Text = "Próximo a terminar";
                else txtEstado.Text = "Disponible";
            }
        }
    }
}



        
    


        
    
        
        
    

        








