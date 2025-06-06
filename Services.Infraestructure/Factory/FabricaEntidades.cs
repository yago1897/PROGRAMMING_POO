using Services.Core.Interfaces;
using Services.Infraestructure.Entidades;
using Services.Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Factory
{
    public static class FabricaEntidades
    {
        // Tipos posibles para productos
        public enum TipoProducto
        {
            Digital,
            Fisico
        }

        // Tipos posibles para usuarios
        public enum TipoUsuario
        {
            Cliente,
            Administrador
        }

        // Método Factory para productos
        public static IProductoBase CrearProducto(TipoProducto tipo)
        {
            return tipo switch
            {
                TipoProducto.Digital => new ProductoDigital(),
                TipoProducto.Fisico => new ProductoFisico(),
                _ => throw new ArgumentException("Tipo de producto no válido")
            };
        }

        
        
    }
}
