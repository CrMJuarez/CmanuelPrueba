using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_C
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte la opcion 1 para agregar un usuario");
            Console.WriteLine("Inserte la opcion 2 para eliminar un usuario");
            int Valor = 0;
            Valor = int.Parse(Console.ReadLine());
            switch (Valor)
            {
                case 1:
                    Usuario.Add();
                    break;

                case 2:
                    Usuario.Delete();
                    break;

            }
            Console.ReadKey();
        }
    }
}
