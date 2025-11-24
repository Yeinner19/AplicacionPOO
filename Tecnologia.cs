using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Tecnologia : Producto
    {
        //Constructor de la clase Tecnologia que hereda de Producto
        public Tecnologia(string nombre, decimal precio, string tipo ) 
            : base(nombre, precio, "Tecnologia" ){ }

        public override decimal CalcularDescuento()
        {
            return Precio * 0.10m;
        }

    }
}
