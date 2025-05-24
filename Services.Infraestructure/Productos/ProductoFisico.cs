using Services.Core.Interfaces;
using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Productos
{
    public class ProductoFisico : IItem
    {
        public int Stock { get; set; }
        public string Descripcion { get; set; }

        public ProductoFisico(int id, string nombre, decimal precio, string descripcion, int stock)
            : base(id, nombre, precio)
        {
            Descripcion = descripcion ?? "";
            if (stock < 0) throw new ArgumentException("El stock no puede ser negativo.");
            Stock = stock;
        }

        public override string MostrarDetalle()
        {
            return $"Producto Físico: {Nombre}, Precio: {Precio}, Stock: {Stock}";
        }
    }
}
