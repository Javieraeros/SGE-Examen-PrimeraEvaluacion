using Ejercicio_2_BL.Manejadoras;
using Ejercicio_2_ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_2_BL.Listados;
using Ejercicio_2_UI.Models;

namespace Ejercicio_2_UI.Controllers
{
    /// <summary>
    /// Funciona, pero no muestra el listado de categorías con el nombre para que tu selecciones una en vez de poner el número.
    /// 
    /// Para solucionar esto, mi idea es crear un nuevo modelo en la capa UI que hereda de la clase producto a la que añadimos 
    /// el listado de categorías.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Método que nos lleva a la vista index, donde tendremos un pequeño formulario para insertar un nuevo producto
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ProductoVM pro = new ProductoVM();
            return View(pro);
        }

        /// <summary>
        /// Método llamado al pulsar el botón create.
        /// Guarda el producto en la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost,ActionName("Index")]
        public ActionResult PostIndex(ProductoVM p)
        {

            ProductoVM pro = new ProductoVM();
            ManejadoraProductos_BL miMane = new ManejadoraProductos_BL();
            Producto producto = new Producto(0, p.IdCategoria, p.NombreProducto);
            int resultado = miMane.insertaProducto(producto);
            return View(pro);
        }
    }
}