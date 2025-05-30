using Services.Core.Clases_abstractas;
using Services.Core.Interfaces;
using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Servicios
{
    public class InventarioDigital : GestorInventario
    {
        private List<Producto> productos = new();

        public override void AñadirProducto(IProductoBase producto)
        {
            if (producto is Producto p)
            {
                productos.Add(p);
            }
            else
            {
                throw new ArgumentException("El producto no es del tipo esperado.");
            }
        }

        public override void EliminarProducto(int productoId)
        {
            productos.RemoveAll(p => p.Id == productoId);
        }

        public override void ActualizarStock(int productoId, int nuevoStock)
        {
            // Inventario digital podría no tener stock limitado, pero aplicamos lógica por consistencia.
            var producto = productos.FirstOrDefault(p => p.Id == productoId);
            if (producto != null)
                producto.Stock = nuevoStock;
        }
    }
}
