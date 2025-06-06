using Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Notificaciones
{
    public class GestorInventario : IObservador
    {
        public void Actualizar(string mensaje)
        {
            Console.WriteLine($"[Inventario] Procesando actualización tras evento: {mensaje}");
        }
    }
}
