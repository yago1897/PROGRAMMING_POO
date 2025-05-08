using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure
{
    public class Carrito
    {
        public List<Producto> Productos { get; private set; }
        public decimal Total => CalcularTotal();

        public Carrito()
        {
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void RemoverProducto(int productoId)
        {
            var producto = Productos.FirstOrDefault(p => p.Id == productoId);
            if (producto != null)
            {
                Productos.Remove(producto);
            }
        }

        private decimal CalcularTotal()
        {
            return Productos.Sum(p => p.Precio);
        }
    }

}
