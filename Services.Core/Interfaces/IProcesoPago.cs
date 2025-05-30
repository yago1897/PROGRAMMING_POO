using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Interfaces
{
    public interface IProcesoPago
    {
        void IniciarPago(decimal monto);
        bool VerificarPago();
        void ConfirmarPago();
    }
}
