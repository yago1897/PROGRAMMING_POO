using Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Notificaciones
{
    public class GestorPedidos : ISujeto
    {
        private readonly List<IObservador> _observadores = new();

        public void Suscribir(IObservador observador) => _observadores.Add(observador);
        public void Desuscribir(IObservador observador) => _observadores.Remove(observador);

        public void Notificar(string mensaje)
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(mensaje);
            }
        }

        public void CambiarEstadoPedido(int pedidoId, string nuevoEstado)
        {
            // Lógica para cambiar estado...
            Notificar($"Pedido #{pedidoId} cambió a estado: {nuevoEstado}");
        }
    }
}
