using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Core.Servicios
{
    public static class FabricaEntidades
    {
        // Crea productos según tipo
        /*public static Producto CrearProducto(string tipo, int id, string nombre, string descripcion, decimal precio, int stock)
        {
            switch (tipo.ToLower())
            {
                case "digital":
                    return new ProductoDigital
                    {
                        Id = id,
                        Nombre = nombre,
                        Descripcion = descripcion,
                        Precio = precio,
                        Stock = stock
                    };

                case "fisico":
                    return new ProductoFisico
                    {
                        Id = id,
                        Nombre = nombre,
                        Descripcion = descripcion,
                        Precio = precio,
                        Stock = stock
                    };

                default:
                    throw new ArgumentException("Tipo de producto no válido.");
            }
        }

        // Crea usuarios según tipo
        public static Usuario CrearUsuario(string tipo, int id, string nombre, string correo)
        {
            switch (tipo.ToLower())
            {
                case "cliente":
                    return new Cliente
                    {
                        Id = id,
                        Nombre = nombre,
                        Correo = correo
                    };

                case "administrador":
                    return new Administrador
                    {
                        Id = id,
                        Nombre = nombre,
                        Correo = correo
                    };

                default:
                    throw new ArgumentException("Tipo de usuario no válido.");
            }
        }*/
    }
}
