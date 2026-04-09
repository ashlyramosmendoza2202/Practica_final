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
    public partial class Menu_Almacen : Form
    {
        public Menu_Almacen()
        {
            InitializeComponent();
        }

        private void Menu_Almacen_Load(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = !panelSubMenu.Visible;
            {
            }
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmMostrarProductos>().Any())
            {
                Application.OpenForms.OfType<FrmMostrarProductos>().First().BringToFront();
                return;
            }
            FrmMostrarProductos frm = new FrmMostrarProductos();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.ActualizarTabla();
        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAgregarProducto>().Any())
            {
                Application.OpenForms.OfType<FrmAgregarProducto>().First().BringToFront();
                return;
            }
            FrmAgregarProducto frm = new FrmAgregarProducto();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();


        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmActualizarProducto>().Any())
            {
                Application.OpenForms.OfType<FrmActualizarProducto>().First().BringToFront();
                return;
            }
            FrmActualizarProducto frm = new FrmActualizarProducto();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExportarProductos>().Any())
            {
                Application.OpenForms.OfType<FrmExportarProductos>().First().BringToFront();
                return;
            }
            FrmExportarProductos frm = new FrmExportarProductos();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            {

            }
        }

        private void FrmAsistenteGlamy_Click(object sender, EventArgs e)
       
        {
            // Creamos la instancia del asistente
            FrmAsistenteGlamy asistente = new FrmAsistenteGlamy();

            // IMPORTANTE: Usa .Show() en lugar de .ShowDialog()
            // .Show() permite que la ventana sea independiente y puedas moverla 
            // mientras sigues usando el menú de atrás.
            asistente.Show();
        }
    }
    }





        
    


    