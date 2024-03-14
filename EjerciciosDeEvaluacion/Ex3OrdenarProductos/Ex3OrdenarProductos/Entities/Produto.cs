using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3OrdenarProductos.Entities
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Precio { get; private set; }

        public Produto(string nome, double precio)
        {
            Nome = nome;
            Precio = precio;
        }

        public override string ToString() => $"{Nome} - {Precio}";
    }
}
