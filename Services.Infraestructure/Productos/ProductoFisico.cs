using Services.Core.Interfaces;
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
        public float Peso { get; set; }





        public ProductoFisico() : base(0, "", "", 0, 0) { }// ← este es el constructor que necesitas
    }
}
