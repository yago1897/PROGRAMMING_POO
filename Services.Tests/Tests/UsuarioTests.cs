using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Tests.Tests
{
    [TestFixture]
    public class UsuarioTests
    {
        [Test]
        public void Constructor_ParametrosValidos_DeberiaCrearUsuario()
        {
            var usuario = new Usuario(1, "Juan", "juan@mail.com", "123456");

            Assert.AreEqual(1, usuario.Id);
            Assert.AreEqual("Juan", usuario.Nombre);
            Assert.AreEqual("juan@mail.com", usuario.Correo);
            Assert.AreEqual("123456", usuario.Contrasena);
            Assert.IsTrue(usuario.EstaAutenticado);
        }

        [Test]
        public void Constructor_IdInvalido_DeberiaLanzarExcepcion()
        {
            Assert.Throws<ArgumentException>(() =>
                new Usuario(0, "Juan", "juan@mail.com", "123456"));
        }

        [Test]
        public void Constructor_NombreVacio_DeberiaLanzarExcepcion()
        {
            Assert.Throws<ArgumentException>(() =>
                new Usuario(1, "", "juan@mail.com", "123456"));
        }

        [Test]
        public void Constructor_CorreoInvalido_DeberiaLanzarExcepcion()
        {
            Assert.Throws<ArgumentException>(() =>
                new Usuario(1, "Juan", "correoInvalido", "123456"));
        }

        [Test]
        public void Constructor_ContrasenaCorta_DeberiaLanzarExcepcion()
        {
            Assert.Throws<ArgumentException>(() =>
                new Usuario(1, "Juan", "juan@mail.com", "123"));
        }

        [Test]
        public void EstaAutenticado_DeberiaPoderModificarse()
        {
            var usuario = new Usuario(1, "Juan", "juan@mail.com", "123456");
            usuario.EstaAutenticado = false;

            Assert.IsFalse(usuario.EstaAutenticado);
        }
    }
}
