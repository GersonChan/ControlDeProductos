using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlDeProductos
{
    public class Alimento : Producto
    {
        public DateTime fechaVencimiento { get; set; }
        public int medida { get; set; }
    }
}