using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlDeProductos
{
    public class Producto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precioCompra { get; set; }
        public int precioVenta { get; set; }
    }
}