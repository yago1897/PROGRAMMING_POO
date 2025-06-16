using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Excepciones
{
    public class UsuarioNoAutenticadoException : Exception
    {
        public UsuarioNoAutenticadoException()
            : base("El usuario no está autenticado o no tiene permisos.")
        {
        }

        public UsuarioNoAutenticadoException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
