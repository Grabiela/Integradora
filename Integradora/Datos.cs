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
            Usuarios.Add(new User { UserName = "Gaby", Password = "0928", Image = "Popeye.jpg" });
            Usuarios.Add(new User { UserName = "Luz", Password = "0516", Image = "zombie.jpg" });
            Usuarios.Add(new User { UserName = "Martin", Password = "1031", Image = "Waldo.jpg" });
            Usuarios.Add(new User { UserName = "Chito", Password = "0212", Image = "Raphael.jpg" });
            Usuarios.Add(new User { UserName = "Poncho", Password = "0601", Image = "Mr Poncho.jpg" });
            Usuarios.Add(new User { UserName = "Daniel", Password = "0827", Image = "CBrown.jpg" });
        }

        public static string GetImagePath(string imageName)
        {
            return Path.Combine(ImagesFolder, imageName);
        }

        // 10 productos precargados
        public static String[,] Productos =
        {
            {"7806610034151", "Bicicleta", "150.00", "bicicleta.jpg"},
            {"7501000132300", "Camara", "385.50", "Camara.jpg"},
            {"766623311731", "Celular", "61.80", "celular.jpg"},
            {"7501055310883", "Reloj", "54.99", "reloj.jpg"},
            {"7501055310883", "Vestido", "325.60", "Dresses.jpg"},
            {"7501055310883", "Aretes", "93.99", "earings.jpg"},
            {"7501055310883", "Control", "167.20", "xbox.jpg"},
            {"7501055310883", "Bolsa", "182.95", "purse.jpg"},
            {"073852029383", "Zapatillas", "350.15", "redshoes.jpg"},
            {"0400005622090", "Gafas", "120.55", "lentes.jpg"},


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
