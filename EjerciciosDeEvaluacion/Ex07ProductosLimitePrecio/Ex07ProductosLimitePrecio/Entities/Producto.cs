using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07ProductosLimitePrecio.Entities
{
    internal class Producto
    {
        public string Nome { get; private set; }
        public double Precio { get; private set; }

        public Producto(string nome, double precio)
        {
            Nome = nome;
            Precio = precio;
        }

        public override string ToString() => $"{Nome} - {Precio}";
    }
}
