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

        public void ActualizarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =
        Datos.listaProductos;
        }
        

        private void FrmMostrarProductos_Load(object sender, EventArgs e)
        {
           
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 30;
               
        {
         
        }
    }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.DataSource = null;
                    if (Datos.listaProductos != null)
                    {
                        dataGridView1.DataSource = Datos.listaProductos;
                    }
                }
                catch (Exception)
                {
                   
                }
            }
        }
       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este producto?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // 3. Obtener el ID de la fila seleccionada
                    int idSeleccionado = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                    // 4. Buscar el producto en la lista de Datos y eliminarlo
                    var producto = Datos.listaProductos.FirstOrDefault(p => p.Id == idSeleccionado);

                    if (producto != null)
                    {
                        Datos.listaProductos.Remove(producto);
                        MessageBox.Show("Producto eliminado correctamente.");

                        // 5. REFRESCAR LA TABLA (Igual que cuando agregas)
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Datos.listaProductos;
                        {
            
            
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila completa para eliminar.");
            }
        }
        {
            // 1. Verificar si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 2. Preguntar al usuario para estar seguros (Buena práctica)
                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este producto?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // 3. Obtener el ID de la fila seleccionada
                    int idSeleccionado = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                    // 4. Buscar el producto en la lista de Datos y eliminarlo
                    var producto = Datos.listaProductos.FirstOrDefault(p => p.Id == idSeleccionado);

                    if (producto != null)
                    {
                        Datos.listaProductos.Remove(producto);
                        MessageBox.Show("Producto eliminado correctamente.");

                        // 5. REFRESCAR LA TABLA (Igual que cuando agregas)
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Datos.listaProductos;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila completa para eliminar.");
            }
        }
    }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        
           
           
    }
    }

