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

        private void btnAgregar_Click(object sender, EventArgs e)
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
            FrmMostrarProductos frm = new FrmMostrarProductos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            FrmAgregarProducto frm = new FrmAgregarProducto();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm,
            
            }
        }
    }
    


    