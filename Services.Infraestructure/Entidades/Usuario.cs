using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Services.Infraestructure.Entidades
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string correo;
        private string contrasena;

        // NUEVA PROPIEDAD:
        public bool EstaAutenticado { get; set; } = true;

        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID debe ser mayor que cero.");
                id = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                nombre = value;
            }
        }

        public string Correo
        {
            get => correo;
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new ArgumentException("Formato de correo electrónico inválido.");
                correo = value;
            }
        }

        public string Contrasena
        {
            get => contrasena;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");
                contrasena = value;
            }
        }

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
