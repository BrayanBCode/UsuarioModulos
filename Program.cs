using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosPorModulos;

namespace UsuariosPorModulos
{
    class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("Arranca");
            Biblioteca bib = new Biblioteca();
            bib.MenuMain();

            System.Console.WriteLine("Termina");

        }
    }
}
