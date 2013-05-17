using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniKino.Programacion.ProyectoIntegrador.Models;
using System.ComponentModel;
using System.Reflection;
using System.IO;

namespace UniKino.Programacion.ProyectoIntegrador
{
    public static class Datos
    {
        public static String UsuarioActual = String.Empty;

        private static string currentAssemblyDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static List<User> Usuarios = new List<User>();

        public static string ImagesFolder
        {
            get
            {
                return String.Format(@"{0}\Images\",
                    currentAssemblyDirectoryName.ToLower()
                                                .Replace(@"\bin\debug", String.Empty)
                                                .Replace(@"\bin\release", String.Empty));
            }
        }

        static Datos()
        {
            Usuarios.Add(new User { UserName = "Gaby", Password = "123", Image = "trinity.jpg" });
            Usuarios.Add(new User { UserName = "Luz", Password = "1234", Image = "next.jpg" });
            Usuarios.Add(new User { UserName = "Martin", Password = "1323", Image = "toK.jpg" });
            Usuarios.Add(new User { UserName = "Chito", Password = "1523", Image = "poe.jpg" });
            Usuarios.Add(new User { UserName = "Poncho", Password = "1823", Image = "Mr Poncho.jpg" });
            Usuarios.Add(new User { UserName = "Daniel", Password = "1273", Image = "animal.jpg" });
        }

        public static string GetImagePath(string imageName)
        {
            return Path.Combine(ImagesFolder, imageName);
        }

        // 10 productos precargados
        public static String[,] Productos =
        {
            {"7806610034151", "Vestido Negro", "150.00", "bicicleta.jpg"},
            {"7501000132300", "Bolsa de mano", "100.00", "Camara.jpg"},
            {"766623311731", "Zapatos Negros", "60.00", "celular.jpg"},
            {"7501055310883", "Collar Turquesa", "56.00", "reloj.jpg"}
        };

        public static bool ValidarUsuario(string user, string pass)
        {
            return
                Usuarios.Any(x => x.UserName == user && x.Password == pass);

            //var valid = false;



            //for (int i = 0; i < Usuarios_original.GetLength(0); i++)
            //{
            //    if (Usuarios_original[i, 0] == user && Usuarios_original[i, 1] == pass)
            //    {
            //        valid = true;
            //        break;
            //    }
            //}

            //return valid;
        }
        
    }
}
