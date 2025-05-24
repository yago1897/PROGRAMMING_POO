using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Entidades
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private decimal precio;
        private int stock;

        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID debe ser mayor que cero.");
                id = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                nombre = value;
            }
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value ?? ""; // Puede estar vacío, pero no nulo
        }

        public decimal Precio
        {
            get => precio;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio no puede ser negativo.");
                precio = value;
            }
        }

        public int Stock
        {
            get => stock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El stock no puede ser negativo.");
                stock = value;
            }
        }

        // Constructor
        public Producto(int id, string nombre, string descripcion, decimal precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }

        public virtual string MostrarDetalle()
        {
            return $"Producto: {Nombre}, Precio: {Precio}";
        }
    }

}
