using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UniKino.Programacion.ProyectoIntegrador.Models;

namespace UniKino.Programacion.ProyectoIntegrador
{
    public static class Datos
    {
        public static String UsuarioActual = String.Empty;

        private static string directorioActual = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static List<Usuario> Usuarios = new List<Usuario>();

        public static string CarpetaDeImagenes
        {
            get
            {
                return String.Format(@"{0}\Images\",
                    directorioActual.ToLower()
                                    .Replace(@"\bin\debug", String.Empty)
                                    .Replace(@"\bin\release", String.Empty));
            }
        }

        static Datos()
        {
            // llenar la lista de usuarios
            Usuarios.Add(new Usuario { Username = "Gaby",   Password = "0928", Image = "Popeye.jpg" });
            Usuarios.Add(new Usuario { Username = "Luz",    Password = "0516", Image = "zombie.jpg" });
            Usuarios.Add(new Usuario { Username = "Martin", Password = "1031", Image = "Waldo.jpg" });
            Usuarios.Add(new Usuario { Username = "Chito",  Password = "0212", Image = "Raphael.jpg" });
            Usuarios.Add(new Usuario { Username = "Poncho", Password = "0601", Image = "Mr Poncho.jpg" });
            Usuarios.Add(new Usuario { Username = "Daniel", Password = "0827", Image = "CBrown.jpg" });
        }

        public static string UbicacionDeLaImagen(string nombre)
        {
            return Path.Combine(CarpetaDeImagenes, nombre);
        }

        // 10 productos precargados
        // Los codigos de los productos deben ser llevados de codigos reales
        public static String[,] Productos =
        {
            // codigo           // descripcion  // precio   // foto
            {"7806610034151",   "Bicicleta",    "15.00",    "bicicleta.jpg"},
            {"750101820010",    "Camara",       "38.50",    "Camara.jpg"},
            {"766623311731",    "Celular",      "6.80",     "celular.jpg"},
            {"3108837501055",   "Reloj",        "54.99",    "reloj.jpg"},
            {"7501055310883",   "Vestido",      "35.60",    "Dresses.jpg"},
            {"7564751680883",   "Aretes",       "93.99",    "earings.jpg"},
            {"750105514785",    "Control",      "16.20",    "xbox.jpg"},
            {"142798310883",    "Bolsa",        "12.95",    "purse.jpg"},
            {"073852029383",    "Zapatillas",   "50.15",    "redshoes.jpg"},
            {"0400005622090",   "Gafas",        "10.55",    "lentes.jpg"},
        };

        public static bool ValidarUsuario(string usuario, string contrasena)
        {
            return Usuarios.Any(x => x.Username.ToLower() == usuario.ToLower() && x.Password == contrasena);
        }

        public static Producto BuscarProducto(string descripcionCodigo)
        {
            Producto producto = null;

            for (int i = 0; i < Productos.GetLength(0); i++)
            {
                // comparar la columna de codigo y la de descripcion
                if (Productos[i, 0].ToLower() == descripcionCodigo.ToLower() ||
                    Productos[i, 1].ToLower() == descripcionCodigo.ToLower())
                {
                    // crear el objecto que se va a regresar
                    producto             = new Producto();
                    producto.Codigo      = Productos[i, 0];
                    producto.Descripcion = Productos[i, 1];
                    producto.Precio      = Convert.ToDecimal(Productos[i, 2]);
                    producto.Imagen      = Productos[i, 3];
                    
                    break; // no necesitamos seguir comparando
                }
            }
            return producto;
        }
    }
}
