using Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Core.Clases_abstractas
{
    public abstract class GestorInventario 
    {
        
        public abstract void AñadirProducto(IProductoBase producto);
        public abstract void EliminarProducto(int productoId);
        public abstract void ActualizarStock(int productoId, int nuevoStock);
    }
}
