using Ejercicio_2_ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_2_DAL.Listados;

namespace Ejercicio_2_BL.Listados
{
   public class ListadosCategorias_BL
    {
        /// <summary>
        /// Método qeu devuelve un listado con todas las categorías de productos de la BBDD
        /// </summary>
        /// <returns></returns>
        public List<Categoria> listadoCategorias()
        {
            ListadoCategorias_DAL miMane = new ListadoCategorias_DAL();

            return miMane.selectCategorias();
        }
    }
}
