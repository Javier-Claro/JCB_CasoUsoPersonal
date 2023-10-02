using Menu.Servicios;
using System.Net.Http.Headers;

namespace ElegirOpcion.Controladores
{

    /// <summary>
    /// Clase Principal de la aplicación
    /// </summary>
    class Program
    {
        static void Main(String[] args)
        {

            MenuInterfaz comida = new MenuImplementacion();
            comida.mostrarMensajeBienvenida();

            //variable que controla la entrada y salida del bucle:

            //contiene la opción del usuario:
            int opcion = 1;

            bool cerrarMenu = false;

            //desde la primera iteración debe de cumplirse la condición:
            while (!cerrarMenu)
            {
                opcion = comida.mostrarMenuYSeleccion();Console.Clear();

                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("\n\t\t\t[INFO] - Esta  buena, pero hay mejores cosas");
                        break;

                    case 2:
                        Console.WriteLine("\n\t\t\t[INFO] - Tienes el mejor gusto del mundo :)");
                        break;

                    case 3:
                        Console.WriteLine("\n\t\t\t[INFO] - No hay opción para escoger ambas O-O");
                        break;

                    default:
                        Console.WriteLine("\n\n\t\t\t[INFO] - La opción deseada no existe.");
                        break;
                }
            }
        }
    }
}