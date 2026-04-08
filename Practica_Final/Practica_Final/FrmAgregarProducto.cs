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
            p.Id = Datos.listaProductos.Count + 1;
            p.Nombre = txtNombre.Text;
            p.Categoria = cmbCategoria.Text;
            p.Necesidad = cmbNecesidad.Text;

            // Convertir cantidad (asumiendo que es un NumericUpDown)
            p.Cantidad = (int)numCantidad.Value;
            int min;
                    if (int.TryParse(txtCantidadMinima.Text, out min))
                    {
                        p.CantidadMinima = min;
                    }

            // Convertir precio
            decimal precio;
            decimal.TryParse(txtPrecioPorUnidad.Text, out precio);
            p.PrecioPorUnidad = precio;

            // ITBIS CALCULADO
            if (p.Necesidad == "Primera") p.ITBIS = p.PrecioPorUnidad * 0.08m;
            else if (p.Necesidad == "Segunda") p.ITBIS = p.PrecioPorUnidad * 0.14m;
            else p.ITBIS = p.PrecioPorUnidad * 0.18m;

                p.PrecioFinal = p.PrecioPorUnidad + p.ITBIS;

                // ESTADO CALCULADO
                int CantidadMinima;
            int.TryParse(txtCantidadMinima.Text, out min);
            if (p.Cantidad == 0) p.Estado = "Agotado s";
            else if (p.Cantidad <= min) p.Estado = "Próximo a terminar";
            else p.Estado = "Disponible";

            // GUARDAR Y REFRESCAR
            Datos.listaProductos.Add(p);
            MessageBox.Show("¡Producto guardado con éxito!");
            this.Close();
        }
    }
        }
    }


    


    

         
         






        