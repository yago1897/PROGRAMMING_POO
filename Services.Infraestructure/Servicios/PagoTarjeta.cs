using Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Servicios
{
    public class PagoTarjeta : IProcesoPago
    {
        public void IniciarPago(decimal monto)
        {
            Console.WriteLine($"Procesando pago con tarjeta por: {monto:C}");
        }

        public bool VerificarPago()
        {
            Console.WriteLine("Verificando pago con tarjeta...");
            return true; // Simulación
        }

        public void ConfirmarPago()
        {
            Console.WriteLine("Pago con tarjeta confirmado.");
        }
    }
}
