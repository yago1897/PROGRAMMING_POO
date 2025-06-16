using Services.Core.Excepciones;
using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Tests.Tests
{
    [TestFixture]
    public class CarritoTests
    {
        [Test]
        public void Constructor_DeberiaInicializarColeccionVacia()
        {
            var carrito = new Carrito();

            Assert.IsNotNull(carrito.Productos);
            Assert.AreEqual(0, carrito.Productos.Count);
        }

        [Test]
        public void AgregarProducto_ObjetoValido_DeberiaAgregarlo()
        {
            var carrito = new Carrito();
            var producto = new Producto(1, "Libro", "Educativo", 20.0m, 10);

            carrito.AgregarProducto(producto);

            Assert.AreEqual(1, carrito.Productos.Count);
            Assert.AreEqual(producto, carrito.Productos.First());
        }

        [Test]
        public void AgregarProducto_Nulo_DeberiaLanzarExcepcion()
        {
            var carrito = new Carrito();

            Assert.Throws<ArgumentNullException>(() =>
            {
                carrito.AgregarProducto((Producto)null);
            });
        }

       

        [Test]
        public void AgregarProducto_NombreVacio_DeberiaLanzarExcepcion()
        {
            var carrito = new Carrito();

            Assert.Throws<ArgumentException>(() =>
            {
                carrito.AgregarProducto("", 99.99m);
            });
        }

        [Test]
        public void AgregarProducto_PrecioNegativo_DeberiaLanzarExcepcion()
        {
            var carrito = new Carrito();

            Assert.Throws<ArgumentException>(() =>
            {
                carrito.AgregarProducto("Monitor", -10.0m);
            });
        }

        [Test]
        public void RemoverProducto_Existente_DeberiaRemoverlo()
        {
            var carrito = new Carrito();
            var producto = new Producto(2, "Mouse", "Periférico", 15.0m, 1);
            carrito.AgregarProducto(producto);

            carrito.RemoverProducto(2);

            Assert.AreEqual(0, carrito.Productos.Count);
        }

        [Test]
        public void RemoverProducto_NoExistente_NoDeberiaFallar()
        {
            var carrito = new Carrito();

            carrito.RemoverProducto(99); // No debería lanzar excepción

            Assert.AreEqual(0, carrito.Productos.Count);
        }

        [Test]
        public void Total_DeberiaSumarPreciosCorrectamente()
        {
            var carrito = new Carrito();
            carrito.AgregarProducto(new Producto(1, "Prod1", "Desc", 10.0m, 1));
            carrito.AgregarProducto(new Producto(2, "Prod2", "Desc", 20.0m, 1));

            Assert.AreEqual(30.0m, carrito.Total);
        }

        [Test]
        public void AñadirProducto_UsuarioNoAutenticado_DeberiaLanzarExcepcion()
        {
            var carrito = new Carrito();
            var usuario = new Usuario(1, "Pedro", "pedro@mail.com", "clave123")
            {
                EstaAutenticado = false
            };

            Assert.Throws<UsuarioNoAutenticadoException>(() =>
            {
                carrito.AñadirProducto(5, 1, usuario);
            });
        }

        [Test]
        public void AñadirProducto_UsuarioNulo_DeberiaLanzarExcepcion()
        {
            var carrito = new Carrito();

            Assert.Throws<UsuarioNoAutenticadoException>(() =>
            {
                carrito.AñadirProducto(5, 1, null);
            });
        }
    }
}
