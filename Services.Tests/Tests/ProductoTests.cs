using NUnit.Framework;
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
    public class ProductoTests
    {
        [Test]
        public void Constructor_Valido_DeberiaCrearProductoCorrectamente()
        {
            var producto = new Producto(1, "Mouse", "Mouse óptico", 25.99m, 10);

            Assert.AreEqual(1, producto.Id);
            Assert.AreEqual("Mouse", producto.Nombre);
            Assert.AreEqual("Mouse óptico", producto.Descripcion);
            Assert.AreEqual(25.99m, producto.Precio);
            Assert.AreEqual(10, producto.Stock);
        }

        [Test]
        public void Constructor_IdInvalido_DeberiaLanzarArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var producto = new Producto(0, "Teclado", "Teclado mecánico", 50.00m, 5);
            });
        }

        [Test]
        public void Nombre_Vacio_DeberiaLanzarArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var producto = new Producto(1, "", "Descripción", 10, 5);
            });
        }

        [Test]
        public void PrecioNegativo_DeberiaLanzarArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var producto = new Producto(1, "Cámara", "Alta resolución", -10.0m, 5);
            });
        }

        [Test]
        public void StockNegativo_DeberiaLanzarArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var producto = new Producto(1, "Auriculares", "Inalámbricos", 30.0m, -3);
            });
        }

        [Test]
        public void ActualizarStock_AumentarStock_DeberiaActualizarCorrectamente()
        {
            var producto = new Producto(1, "Laptop", "Portátil", 1000m, 5);

            producto.ActualizarStock(3);

            Assert.AreEqual(8, producto.Stock);
        }

        [Test]
        public void ActualizarStock_DisminuirStock_DeberiaActualizarCorrectamente()
        {
            var producto = new Producto(1, "Laptop", "Portátil", 1000m, 10);

            producto.ActualizarStock(-4);

            Assert.AreEqual(6, producto.Stock);
        }

        [Test]
        public void ActualizarStock_DisminuirMasDelStock_DeberiaLanzarProductoNoDisponibleException()
        {
            var producto = new Producto(1, "Monitor", "Full HD", 250.0m, 3);

            Assert.Throws<ProductoNoDisponibleException>(() =>
            {
                producto.ActualizarStock(-5);
            });
        }
    }
}
