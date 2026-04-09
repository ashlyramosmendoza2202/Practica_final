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
    public partial class FrmAsistenteGlamy : Form
    {
        public FrmAsistenteGlamy()
        {
            InitializeComponent();
        }

        private void btnPreguntar_Click(object sender, EventArgs e)
        {
     
        {
            string pregunta = txtPregunta.Text.ToLower().Trim();
             richTextBox1.Text = "";
            bool esTemaDeAlmacen = false;

            // 1. CONSULTA DE STOCK (Unidades, cantidades)
            if (pregunta.Contains("stock") || pregunta.Contains("cuanto hay") || pregunta.Contains("quedan") || pregunta.Contains("unidades"))
            {
                int totalUnidades = Datos.listaProductos.Sum(p => p.Cantidad);
            richTextBox1.Text = $"En el almacén tenemos un total de {totalUnidades} unidades disponibles entre todos los productos.";
                esTemaDeAlmacen = true;
            }

            // 2. CONSULTA DE VALOR (Dinero, costos)
            else if (pregunta.Contains("precio") || pregunta.Contains("valor") || pregunta.Contains("dinero") || pregunta.Contains("costo"))
            {
                decimal totalDinero = Datos.listaProductos.Sum(p => p.PrecioFinal);
              richTextBox1.Text = $"El valor monetario de todo lo que hay en el almacén ahora mismo es de RD$ {totalDinero:N2}.";
                esTemaDeAlmacen = true;
            }

            // 3. CONSULTA DE PRODUCTOS ESPECÍFICOS
            else if (pregunta.Contains("producto") || pregunta.Contains("articulo") || pregunta.Contains("que tengo"))
            {
                int tipos = Datos.listaProductos.Count;
               richTextBox1.Text = $"Actualmente manejamos {tipos} tipos de artículos diferentes en el registro del almacén.";
                esTemaDeAlmacen = true;
            }

            // 4. CONSULTA DE ESTADO (Stock bajo)
            else if (pregunta.Contains("bajo") || pregunta.Contains("faltan") || pregunta.Contains("agotado"))
            {
                int bajo = Datos.listaProductos.Count(p => p.Cantidad <= 5);
               richTextBox1.Text = $"Hay {bajo} productos que están por agotarse. Deberías pedir más mercancía para el almacén.";
                esTemaDeAlmacen = true;
            }

            // --- EL FILTRO DE SEGURIDAD (Si pregunta otra cosa como "¿Cómo estás?") ---
            if (!esTemaDeAlmacen)
            {
              richTextBox1.Text = "Lo siento, no puedo responder eso. Solo puedo responder todo lo relacionado al almacén de GlamInventory.";
            }

            txtPregunta.Clear();
            txtPregunta.Focus();
        }
    }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
       
        {
            txtPregunta.Clear();    // Borra lo que el usuario escribió
             richTextBox1.Text = ""; // Borra la respuesta de Glammy
            txtPregunta.Focus();    // Pone el cursor listo para escribir de nuevo
        }
    }
    }
}
