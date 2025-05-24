using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Interfaces
{
    public abstract class IItem
    {
        public int Id { get; protected set; }
        public string Nombre { get; protected set; }
        public decimal Precio { get; protected set; }

        protected IItem(int id, string nombre, decimal precio)
        {
            if (id <= 0) throw new ArgumentException("El ID debe ser mayor que cero.");
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre no puede estar vacío.");
            if (precio < 0) throw new ArgumentException("El precio no puede ser negativo.");

            Id = id;
            Nombre = nombre;
            Precio = precio;
        }

        public abstract string MostrarDetalle();


    }
}
