using Services.Core.Excepciones;
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

        public void VerificarDisponibilidad(int productoId, int cantidadSolicitada)
        {
            // Supongamos que consultamos el inventario...
            int cantidadDisponible = 0; // Simulación de inventario vacío

            if (cantidadDisponible < cantidadSolicitada)
            {
                throw new ProductoNoDisponibleException($"El producto con ID {productoId} no tiene suficiente stock.");
            }

            // Lógica normal...
        }
    }
}
