using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Interfaces
{
    public interface ISujeto
    {
        void Suscribir(IObservador observador);
        void Desuscribir(IObservador observador);
        void Notificar(string mensaje);
    }
}
