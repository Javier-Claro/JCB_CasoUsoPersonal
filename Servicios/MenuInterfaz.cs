using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida.
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Método que muestra el mení y recoge la selección del usuario.
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
