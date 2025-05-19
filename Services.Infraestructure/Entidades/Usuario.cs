using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public Usuario(int id, string nombre, string correo, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Contrasena = contrasena;
        }

        ~Usuario()
        {
            // Destructor opcional (no suele ser necesario en .NET Core).
        }
    }

}
