using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniKino.Programacion.ProyectoIntegrador.Models
{
    public class Product
    {
        public int Cantidad { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get { return Cantidad * Precio; } }
        public string Imagen { get; set; }
    }
}
