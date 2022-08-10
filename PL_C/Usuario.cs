using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_C
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingrese el nombre de usuario");
            usuario.Nombre= Console.ReadLine();
            Console.WriteLine("Ingrese el apellido paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el sexo");
            usuario.Sexo = Console.ReadLine();
            ML.Result result = BL.Usuario.Add(usuario);
            if (result.Correct)
            {
                Console.WriteLine("Usuario insertado correctamente");
            }else
            {
                Console.WriteLine("No se pudo insertar el usuario");
            }
           
        }
        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Inserte el Id del usuaio a eliminar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.Delete(usuario);
            if (result.Correct)
            {
                Console.WriteLine("Usuario elminado");
            }
            else
            {
                Console.WriteLine("Usuario no se pudo eliminar");
            }
        }
    }
}
