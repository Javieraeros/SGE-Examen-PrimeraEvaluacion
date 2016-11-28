using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ejercicio_2_ENT;
using Ejercicio_2_BL;
using Ejercicio_2_BL.Listados;

namespace Ejercicio_2_UI.Models
{
    public class ProductoVM : Producto
    {
        public List<Categoria> ListaCategorias { get; set; }

        public ProductoVM()
            : base()
        {
            ListadosCategorias_BL miListador = new ListadosCategorias_BL();
            this.ListaCategorias = miListador.listadoCategorias();
        }
    }
}