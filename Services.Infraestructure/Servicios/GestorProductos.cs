using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Servicios
{
    public class GestorProductos
    {
        public void MostrarInformacionProducto(Producto producto)
        {
            Console.WriteLine(producto.MostrarDetalle());
        }
    }
}
