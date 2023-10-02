using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public void mostrarMensajeBienvenida()
        {
            string mensaje = "\t\t\t\t\t\t\tWelcome";
            Console.Write(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionEntrada;

            Console.WriteLine("\n\n\t0: Cerrar app");
            Console.WriteLine("\n\t1: Tortilla de patata");
            Console.WriteLine("\n\t2: Lasaña");
            Console.WriteLine("\n\t3: Ambas");
            Console.Write("\n\t¿Qué te gusta más?: ");

            opcionEntrada = Console.ReadKey(true).KeyChar - ('0');

            return opcionEntrada;
        }
    }
}
