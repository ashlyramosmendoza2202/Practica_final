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
        private DataGridView dgvProductos;

        public FrmActualizarProducto()
        {
            InitializeComponent();
            dgvProductos = new DataGridView();
        }


      
        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                txtBusqueda.Text = "Ingrese ID o Nombre..."; 
                txtBusqueda.ForeColor = Color.Gray;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
     
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                txtNombre.Text = "";
                return;
            }

     
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
                try
                {
                  
                    if (string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtMinima.Text))
                    {
                        MessageBox.Show("Por favor, completa los campos de Precio y Cantidad.");
                        return;
                    }

                    double precio = Convert.ToDouble(txtPrecio.Text);
                    int cantidad = Convert.ToInt32(txtMinima.Text);
                    int cantidadMinima = Convert.ToInt32(txtMinima.Text);

               
                    double itbisCalculado = precio * 0.18;
                    double precioFinalCalculado = precio + itbisCalculado;

                    string nuevoEstado = (cantidad <= cantidadMinima) ? "Próximo a terminar" : "Suficiente";

                  
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = Datos.listaProductos;

                    MessageBox.Show("¡Producto actualizado correctamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var p = Datos.listaProductos.FirstOrDefault(x => x.Id.ToString() == txtID.Text);

            if (p != null)
            {
          
                Datos.listaProductos.Remove(p);

                MessageBox.Show("Producto eliminado correctamente.");

               
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

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtBusqueda.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
                    {
                        MessageBox.Show("Por favor, completa el ID para buscar y el nuevo precio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    int idABuscar = Convert.ToInt32(txtBusqueda.Text);
                    var productoAActualizar = Datos.listaProductos.FirstOrDefault(p => p.Id == idABuscar);

                    if (productoAActualizar == null)
                    {
                        MessageBox.Show("Producto no encontrado. Asegúrate de que el ID sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    string nombre = txtNombre.Text;
                    string categoria = cmbCategoria.Text;
                    string necesidad = cmbNecesidad.Text; 
                    decimal precio;
                    
                    if (!decimal.TryParse(txtPrecio.Text, out precio))
                    {
                        MessageBox.Show("El precio ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int cantidad = Convert.ToInt32(numCantidad.Value);
                    int cantidadMinima = Convert.ToInt32(numCantidad.Value); 
                   
                    decimal itbisCalculado;
                    if (necesidad == "Primera")
                    {
                        itbisCalculado = precio * 0.08m; // 8%
                    }
                    else if (necesidad == "Segunda")
                    {
                        itbisCalculado = precio * 0.14m; // 14%
                    }
                    else if (necesidad == "Tercera")
                    {
                        itbisCalculado = precio * 0.18m; // 18%
                    }
                    else
                    {
                  
                        itbisCalculado = 0m;
                    }

          
                    decimal precioFinalCalculado = precio + itbisCalculado;

              
                    string nuevoEstado;
                    if (cantidad <= 0)
                    {
                        nuevoEstado = "Sin existencia";
                    }
                    else if (cantidad <= cantidadMinima)
                    {
                        nuevoEstado = "Próximo a terminar";
                    }
                    else
                    {
                        nuevoEstado = "Disponible";
                    }

        
                    productoAActualizar.Nombre = nombre;
                    productoAActualizar.Categoria = categoria;
                    productoAActualizar.Necesidad = necesidad;
                    productoAActualizar.Cantidad = cantidad;
                    productoAActualizar.PrecioPorUnidad = precio;
                    productoAActualizar.ITBIS = itbisCalculado;
                    productoAActualizar.CantidadMinima = cantidadMinima;
                    productoAActualizar.Estado = nuevoEstado; 
                    productoAActualizar.PrecioFinal = precioFinalCalculado; 

                   
                    ActualizarTabla();

                    MessageBox.Show("¡Producto '" + nombre + "' actualizado y recalculado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: Asegúrate de llenar todos los campos correctamente. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ActualizarTabla()
        {
         
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Datos.listaProductos;
        }
    }
}
























