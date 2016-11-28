using Ejercicio_2_DAL;
using Ejercicio_2_ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_BL.Manejadoras
{
    public class ManejadoraProductos_BL
    {
        /// <summary>
        /// Inserta un producto en la base de datos.
        /// En caso de haber un error devolverá 0, en caso  contrario 1
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int insertaProducto(Producto p)
        {
            ManejadoraProducto_DAL miMane = new ManejadoraProducto_DAL();
            return miMane.insertaProducto(p);
        }
    }
}
