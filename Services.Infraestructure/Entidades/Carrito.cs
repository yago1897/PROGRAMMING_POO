using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Entidades
{
    public class Carrito
    {
        public List<Producto> Productos { get; private set; }
        public decimal Total => CalcularTotal();

        public Carrito()
        {
            Productos = new List<Producto>();
        }

        // Se agregan por objeto Producto
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        // Por ID (simulado, normalmente buscarías en BD o lista)
        public void AgregarProducto(int id)
        {
            // Simulación
            var producto = new Producto(id, "ProductoSimulado", "Simulado", 10.0m, 5);
            Productos.Add(producto);
        }

        // Se agregan por nombre y precio
        public void AgregarProducto(string nombre, decimal precio)
        {
            var producto = new Producto(0, nombre, "Sin descripción", precio, 1);
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
