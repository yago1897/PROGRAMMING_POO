using Services.Infraestructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infraestructure.Productos
{
    public class ProductoFisico : Producto
    {
        public decimal Peso { get; set; }         // en kg
        public string Dimensiones { get; set; }   // Ej: "30x20x10 cm"

        public ProductoFisico(int id, string nombre, string descripcion, decimal precio, int stock, decimal peso, string dimensiones)
            : base(id, nombre, descripcion, precio, stock)
        {
            Peso = peso;
            Dimensiones = dimensiones;
        }
    }
}
