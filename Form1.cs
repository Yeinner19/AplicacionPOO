using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Producto> listaProductos = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = producto.Text.Trim();
            string precioTexto = price.Text.Trim();
            string tipo = cbTipo.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo de producto no puede estar vacío, ingrese un producto.");
                return;
            }

            decimal precio;
            if (!decimal.TryParse(price.Text.Trim(), out precio) || precio <= 0)
            {
                MessageBox.Show("El precio no es válido. Ingrese un número positivo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Debe seleccionar un tipo de producto.");
                return;
            }

            // Crear el objeto Producto
            Producto nuevoProducto = new Producto(nombre, precio, tipo);


            // Agregar el producto a la lista
            listaProductos.Add(nuevoProducto);

            //Mostrarlo en el MessageBox
            MessageBox.Show($"Producto agregado:\nNombre: {nuevoProducto.Nombre}\nPrecio: {nuevoProducto.Precio}\nTipo: {nuevoProducto.Tipo}");


            MessageBox.Show("Producto agregado exitosamente.");

            if (tipo == "Tecnologia")
                nuevoProducto = new Tecnologia(nombre, precio, tipo);
            else if (tipo == "Alimentos")
                nuevoProducto = new Alimentos(nombre, precio, tipo);
            else
                nuevoProducto = new General(nombre, precio, tipo);

            decimal descuento = nuevoProducto.CalcularDescuento();


            MessageBox.Show(
                $"Producto: {nuevoProducto.Nombre}\n" +
                $"Precio: ${nuevoProducto.Precio:F2}\n" +
                $"Descuento: ${descuento:F2}\n" +
                $"Precio Final: ${(precio - descuento):F2}"
            );

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
