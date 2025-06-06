using Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Notificaciones
{
    public class NotificadorUI : IObservador
    {
        public void Actualizar(string mensaje)
        {
            Console.WriteLine($"[UI] Notificación: {mensaje}");
        }
    }
}
