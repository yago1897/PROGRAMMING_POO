using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Productos
{
    public class ProductoDigital : Producto
    {
        public string FormatoArchivo { get; set; }   // Ej: "PDF", "MP3", "MP4"
        public double TamanoMB { get; set; }         // en Megabytes

        public ProductoDigital(int id, string nombre, string descripcion, decimal precio, int stock, string formatoArchivo, double tamanoMB)
            : base(id, nombre, descripcion, precio, stock)
        {
            FormatoArchivo = formatoArchivo;
            TamanoMB = tamanoMB;
        }
    }
}
