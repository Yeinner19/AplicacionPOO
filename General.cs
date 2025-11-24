using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class General : Producto 
    {
        //Constructor de la clase General que hereda de Producto
        public General(string nombre, decimal precio, string tipo)
            : base(nombre, precio, "General") { }
        public override decimal CalcularDescuento()
        {
            return Precio * 0.05m;
        }
    }   
    
}

