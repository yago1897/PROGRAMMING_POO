using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Usuarios
{
    public class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string correo, string contrasena)
        : base(id, nombre, correo, contrasena)
        {
        }

        public void GestionarInventario()
        {
            Console.WriteLine("El administrador está gestionando el inventario.");
        }

        public void EstablecerPromocion(string producto, decimal descuento)
        {
            Console.WriteLine($"Se ha aplicado un descuento de {descuento:P0} al producto: {producto}");
        }
    }
}
