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

        private void btnEnviar_Click(object sender, EventArgs e)
          
        {
            string pregunta = txtPregunta.Text.ToLower();

            if (pregunta.Contains("agregar"))
            {
                txtRespuesta.Text = "Para agregar un producto al almacén debes dirigirte al formulario de registro de productos.\r\n\r\n" +
                "Luego, completa todos los campos requeridos como nombre, precio, cantidad y categoría.\r\n" +
                "Asegúrate de que los datos sean correctos antes de guardar.\r\n\r\n" +
                "Finalmente, presiona el botón de guardar para registrar el producto correctamente en el sistema.";
            }
            else if (pregunta.Contains("actualizar"))
            {
                txtRespuesta.Text = "Para actualizar un producto, primero debes buscarlo en la lista o mediante su ID.\r\n\r\n" +
                "Una vez localizado, selecciona el producto y modifica los datos que necesites cambiar.\r\n" +
                "Después, presiona el botón actualizar para guardar los cambios.\r\n\r\n" +
                "El sistema reflejará automáticamente la información actualizada.";
            }
            else if (pregunta.Contains("eliminar"))
            {
                txtRespuesta.Text = "Para eliminar un producto del sistema, debes seleccionarlo en la lista de productos.\r\n\r\n" +
                "Luego, presiona el botón eliminar.\r\n" +
                "Es posible que el sistema te pida confirmación antes de borrarlo.\r\n\r\n" +
                "Ten en cuenta que esta acción no se puede deshacer.";
            }
            else if (pregunta.Contains("buscar") || pregunta.Contains("id"))
            {
                txtRespuesta.Text = "Para buscar un producto por ID, debes ingresar el código en el campo de búsqueda.\r\n\r\n" +
                "Luego, presiona el botón buscar.\r\n" +
                "El sistema mostrará automáticamente el producto si existe.\r\n\r\n" +
                "Esto te permite localizar productos de forma rápida y precisa.";
            }
            else if (pregunta.Contains("itbis"))
            {
                txtRespuesta.Text = "El ITBIS es un impuesto aplicado a los productos.\r\n\r\n" +
                "El sistema calcula automáticamente el ITBIS dependiendo del porcentaje configurado (por ejemplo 18%).\r\n" +
                "Este valor se suma al precio del producto para obtener el total.\r\n\r\n" +
                "No necesitas calcularlo manualmente.";
            }
            else
            {
                txtRespuesta.Text = "Solo puedo contestar preguntas relacionadas al almacén de Ashly Ramos ❤️\r\n\r\n" +
                "Intenta hacer una pregunta sobre productos, registros, actualización o funcionamiento del sistema.";
                txtPregunta.Clear();
            }
        }








        private void FrmAsistenteGlamy_Load(object sender, EventArgs e)
        {

            {
                txtRespuesta.Text = "Hola, soy tu asistente virtual Glammy 💜\r\n\r\n" +
                "Puedo ayudarte con preguntas como:\r\n" +
                "- ¿Cómo agregar un producto?\r\n" +
                "- ¿Cómo actualizar un producto?\r\n" +
                "- ¿Cómo eliminar un producto?\r\n" +
                "- ¿Cómo buscar un producto por ID?\r\n" +
                "- ¿Cómo funciona el ITBIS?\r\n\r\n" +
                "Escribe tu pregunta y presiona ENVIAR 😊";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
        {
            txtPregunta.Clear();   
            txtRespuesta.Clear();

            txtPregunta.Focus();  
        }
    }
    }
}