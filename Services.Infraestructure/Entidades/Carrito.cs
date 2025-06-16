using Services.Core.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Entidades
{
    public class Carrito
    {
        private List<Producto> productos;
        public IReadOnlyCollection<Producto> Productos => productos.AsReadOnly();
        public decimal Total => CalcularTotal();

        public Carrito()
        {
            productos = new List<Producto>();
        }

        // Se agregan por objeto Producto
        public void AgregarProducto(Producto producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            productos.Add(producto);
        }

        
        public void AgregarProducto(int id)
        {
            var producto = new Producto(id, "ProductoSimulado", "Simulado", 10.0m, 5);
            productos.Add(producto);
        }

        // Se agregan por nombre y precio
        public void AgregarProducto(string nombre, decimal precio)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo.");

            var producto = new Producto(0, nombre, "Sin descripción", precio, 1);
            productos.Add(producto);
        }

        public void RemoverProducto(int productoId)
        {
            var producto = productos.FirstOrDefault(p => p.Id == productoId);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }

        private decimal CalcularTotal()
        {
            return productos.Sum(p => p.Precio);
        }

        public void AñadirProducto(int productoId, int cantidad, Usuario usuario)
        {
            if (usuario == null || !usuario.EstaAutenticado)
            {
                throw new UsuarioNoAutenticadoException("Debe iniciar sesión para añadir productos al carrito.");
            }

            
        }
    }

}
