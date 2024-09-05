using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public  class Inventario
    {
        public string nombre;
        public int cantidad;
        public int contador;

        public Inventario(string nombre, int cantidad, int contador)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.contador = contador;
        }
    }
}
