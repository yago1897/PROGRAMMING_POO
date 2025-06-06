using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.ConfiguracionGestores
{
    public class ServicioAutenticacion
    {
        public void IniciarSesion()
        {
            // Accedemos a la única instancia de configuración
            var config = ConfiguracionSistema.Instancia;

            // Podemos usar sus valores
            Console.WriteLine($"Usando base de datos: {config.CadenaConexionBD}");

            // También podríamos cambiar valores (si tiene sentido)
            config.TemaUI = "Oscuro";
        }
    }
}
