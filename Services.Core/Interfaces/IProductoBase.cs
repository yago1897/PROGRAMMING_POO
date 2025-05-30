using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Interfaces
{
    public interface IProductoBase
    {
        int Id { get; }
        string Nombre { get; }
        string Descripcion { get; }
        decimal Precio { get; }
        int Stock { get; }
    }
}
