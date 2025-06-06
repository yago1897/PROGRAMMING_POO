using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.ConfiguracionGestores
{
    public sealed class ConfiguracionSistema
    {
        // Instancia única (Lazy Initialization para asegurar que se cree una sola vez de forma segura)
        private static readonly Lazy<ConfiguracionSistema> instancia =
            new Lazy<ConfiguracionSistema>(() => new ConfiguracionSistema());

        // Esta propiedad pública es para acceder a la instancia
        public static ConfiguracionSistema Instancia => instancia.Value;

        // Configuraciones esenciales del sistema, por ejemplo para acceder a base de datos
        public string CadenaConexionBD { get; set; }
        public string TemaUI { get; set; }
        public string Idioma { get; set; }

        // Constructor privado para evitar instanciación directa
        private ConfiguracionSistema()
        {
            // Inicialización con valores por defecto
            CadenaConexionBD = "Server=localhost;Database=EcommerceDB;Trusted_Connection=True;";
            TemaUI = "Claro";
            Idioma = "es-ES";
        }

        // Método para mostrar configuración (opcional, para pruebas)
        public void MostrarConfiguracion()
        {
            Console.WriteLine($"Base de Datos: {CadenaConexionBD}");
            Console.WriteLine($"Tema UI: {TemaUI}");
            Console.WriteLine($"Idioma: {Idioma}");
        }
    }
}
