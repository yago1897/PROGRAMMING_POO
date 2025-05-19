using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Usuarios
{
    public class Cliente : Usuario
    {
        public List<string> HistorialCompras { get; set; } = new();
        public List<string> Preferencias { get; set; } = new();

        public Cliente(int id, string nombre, string correo, string contrasena)
            : base(id, nombre, correo, contrasena)
        {
        }

        public void AgregarCompra(string producto)
        {
            HistorialCompras.Add(producto);
        }

        public void AgregarPreferencia(string categoria)
        {
            Preferencias.Add(categoria);
        }
    }
}
