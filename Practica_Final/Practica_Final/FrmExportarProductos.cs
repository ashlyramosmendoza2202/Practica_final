using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Practica_Final
{
    public partial class FrmExportarProductos : Form
    {
        public FrmExportarProductos()
        {
            InitializeComponent();

       
        {
           
        {
    


        {
        

            // 1. Forzamos el tamaño cuadrado AQUÍ para que no sea un rectángulo
            btnExportar.Width = 200;
            btnExportar.Height = 200;

            // 2. Quitamos bordes y ponemos el fondo transparente 
            // para que solo se vea tu icono morado
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.BackColor = Color.Transparent;
            btnExportar.Text = "";

            // 3. EL TRUCO FINAL: El recorte circular "bola de nieve"
            // Lo ponemos en el evento Paint para que se actualice siempre
            btnExportar.Paint += (s, e) => {
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, btnExportar.Width, btnExportar.Height);
                btnExportar.Region = new Region(gp);
            };
        }
    };
        }
    }
        
        

        private void btnExportar_Click(object sender, EventArgs e)
        {


            SaveFileDialog guardarArchivo = new SaveFileDialog();

            guardarArchivo.Filter = "Archivo CSV (*.csv)|*.csv";
            guardarArchivo.Title = "Guardar reporte de inventario";


            guardarArchivo.FileName = "Inventario_GlamInventory_" + DateTime.Now.ToString("dd-MM-yyyy");


            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(guardarArchivo.FileName))
                    {
                        // Encabezados
                        sw.WriteLine("ID;Nombre;Categoria;Cantidad;Precio;ITBIS;Estado;PrecioFinal");
                        foreach (var p in Datos.listaProductos)
                        {
                            sw.WriteLine($"{p.Id};{p.Nombre};{p.Categoria};{p.Cantidad};{p.PrecioPorUnidad};{p.ITBIS};{p.Estado};{p.PrecioFinal}");
                        }
                    }
                    MessageBox.Show("¡Guardado correctamente en la carpeta seleccionada!", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar: " + ex.Message);
                }
            }
        }


        private void btnExportar_Paint(object sender, PaintEventArgs e)
        {

            {
                // 1. Definimos el área circular
                System.Drawing.Drawing2D.GraphicsPath formaCircular = new System.Drawing.Drawing2D.GraphicsPath();
                formaCircular.AddEllipse(0, 0, btnExportar.Width, btnExportar.Height);

                // 2. Aplicamos el recorte al botón
                btnExportar.Region = new Region(formaCircular);

                // 3. (Opcional) Suavizar los bordes para que no se vea "pixelado"
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                this.BeginInvoke((MethodInvoker)delegate {
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(0, 0, btnExportar.Width, btnExportar.Height);
                    btnExportar.Region = new Region(gp);
                });
            }
        }
    }
    }      

           
            
        

        
        
     
              








  