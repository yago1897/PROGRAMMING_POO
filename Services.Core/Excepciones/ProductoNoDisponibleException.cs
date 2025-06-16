using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Excepciones
{
    public class ProductoNoDisponibleException : Exception
    {
        public ProductoNoDisponibleException()
            : base("El producto no está disponible en inventario.")
        {
        }

        public ProductoNoDisponibleException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
