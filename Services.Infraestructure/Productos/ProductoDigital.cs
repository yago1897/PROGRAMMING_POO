using Services.Core.Interfaces;
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
        public string? UrlDescarga { get; set; }



    

        public ProductoDigital() : base(0, "", "",0,0) { }// ← este es el constructor que necesitas
    }
}
