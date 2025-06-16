using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Excepciones
{
    public class PagoFallidoException : Exception
    {
        public PagoFallidoException()
            : base("El proceso de pago ha fallado.")
        {
        }

        public PagoFallidoException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
