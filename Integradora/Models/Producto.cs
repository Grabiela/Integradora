using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniKino.Programacion.ProyectoIntegrador.Models
{
    public class Producto
    {
        public int Cantidad { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public decimal Subtotal { get { return Cantidad * Precio; } }
    }
}
