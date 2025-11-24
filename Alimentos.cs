using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Alimentos : Producto
    {
        //Constructor de la clase Alimentos que hereda de Producto
        public Alimentos(string nombre, decimal precio, string tipo)
            : base(nombre, precio, "Alimentos") { }

        public override decimal CalcularDescuento()
        {
            return Precio * 0.02m;
        }
    }
}
