using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlDeProductos
{
    public class Electronico : Producto
    {
        public string tiempoGarantia { get; set; }
        public string voltaje { get; set; }
    }
}