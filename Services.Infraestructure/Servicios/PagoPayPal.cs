using Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Servicios
{
    public class PagoPayPal : IProcesoPago
    {
        public void IniciarPago(decimal monto)
        {
            Console.WriteLine($"Redirigiendo a PayPal para pagar: {monto:C}");
        }

        public bool VerificarPago()
        {
            Console.WriteLine("Verificando estado de PayPal...");
            return true; // Simulación
        }

        public void ConfirmarPago()
        {
            Console.WriteLine("Pago con PayPal confirmado.");
        }
    }
}
