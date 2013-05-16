using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniKino.Programacion.ProyectoIntegrador.Models;
using System.ComponentModel;

namespace UniKino.Programacion.ProyectoIntegrador
{
    public static class Datos
    {
        public static String UsuarioActual = "Yo Mera!!!";

        public static List<User> Usuarios = new List<User>();

        static Datos()
        {
            Usuarios.Add(new User { UserName = "Gaby", Password = "123", Image = "trinity.jpg" });
            Usuarios.Add(new User { UserName = "Luz", Password = "1234", Image = "next.jpg" });
            Usuarios.Add(new User { UserName = "Martin", Password = "1323", Image = "toK.jpg" });
            Usuarios.Add(new User { UserName = "Chito", Password = "1523", Image = "poe.jpg" });
            Usuarios.Add(new User { UserName = "Poncho", Password = "1823", Image = "Mr Poncho.jpg" });
            Usuarios.Add(new User { UserName = "Daniel", Password = "1273", Image = "animal.jpg" });
        }


        public static String[,] Usuarios_original = {
                             {"humberto", "123", @"c\\:1.jpg"},
                             {"panchito", "546", @"c\\:2.jpg"},
                             {"raulitos", "098", @"c\\:3.jpg"},
                             {"mikessss", "241", @"c\\:4.jpg"}
                             };

        // 10 productos precargados
        public static String[,] Productos =
        {
            {"7806610034151", "Cuaderno", "7.00", @"C:\Users\Fer\Pictures\Escuelita\Programacion\images (2).jpg"},
            {"7501000132300", "Bollitos", "10.00", @"C\:NOSE.jpg"},
            {"766623311731", "Empanadas", "6.00", @"C\:NOSE.jpg"},
            {"7501055310883", "Coyotas", "5.00", @"C\:NOSE.jpg"}
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
