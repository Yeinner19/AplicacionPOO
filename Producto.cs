using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Tipo { get; set; }


        //Construcor de la clase Producto
        public Producto(string nombre, decimal precio, string tipo)
        {
            Nombre = nombre;
            Precio = precio;
            Tipo = tipo;
        }

        //Constructor vacio para que la clase Producto pueda ser heredada
        public Producto()
        {

        }

        public virtual decimal CalcularDescuento()
        {
            return 0;
        }   


    }
}
