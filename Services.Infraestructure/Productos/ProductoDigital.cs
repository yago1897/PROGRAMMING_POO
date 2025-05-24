using Services.Core.Interfaces;
using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Productos
{
    public class ProductoDigital : IItem
    {
        public string UrlDescarga { get; set; }

        public ProductoDigital(int id, string nombre, decimal precio, string urlDescarga)
            : base(id, nombre, precio)
        {
            UrlDescarga = string.IsNullOrWhiteSpace(urlDescarga)
                ? throw new ArgumentException("Debe proporcionar una URL válida.")
                : urlDescarga;
        }

        public override string MostrarDetalle()
        {
            return $"Producto Digital: {Nombre}, Precio: {Precio}, Descarga: {UrlDescarga}";
        }
    }
}
