using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result Add (ML.Usuario usuario)
        {
            ML.Result result = new ML.Result ();
            using (DL.CmanuelPruebaEntities context = new DL.CmanuelPruebaEntities ())
            {
                var query = context.UsuarioAdd(usuario.Nombre,usuario.ApellidoPaterno,usuario.ApellidoMaterno,usuario.Sexo);
                if (query >= 1)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "No se inserto el usuario";
                }

            }
            return result;
        }
        public static ML.Result Delete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            using(DL.CmanuelPruebaEntities context= new DL.CmanuelPruebaEntities ())
            {
                var query =context.UsuarioDelete(usuario.IdUsuario);
                if (query >= 1)
                {
                    result.Correct=true;
                }
                else
                {
                    result.Correct=false;
                    result.ErrorMessage = "Error al eliminar el usuario";
                }
            }
            return (result);
        }
    }
}
