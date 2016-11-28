using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_1_BL.Manejadora;
using System.Data.SqlClient;
using Ejercicio_1_ENT;
using System.Web.UI.WebControls;

namespace Ejercicio_1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Controlador de la vista Principal
        /// En esta vista será dnde recogeremos el nick de la persona y el id de la que queremos mostrar
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //Cada vez que vayamos al index cerraremos sesión.
            Session.Clear();
            Session.Abandon();
            return View();
        }

        /// <summary>
        /// Controlador al que llamaremos cuando pulsemos el botón siguiente en la vista Index.
        /// Este controlador se encargará de redireccionaros a la página de error si el id es incorrecto, o nos
        /// mostrará los detalles de la persona si el id se encuentrá en la BBDD.
        /// </summary>
        /// <returns></returns>
        [HttpPost,ActionName("Index")]
        public ActionResult PostIndex()
        {
            //Recuperamos el Nick y lo guardamos en la variable de session usuario
            Session["usuario"] = Request.Form["nick"];

            Manejadora_Persona_BL miMane = new Manejadora_Persona_BL();
            //Cogemos el id y miramos si dicho id se encuetra en la BBDD, de no ser así, vamos a la pagina de error
            try
            {
                int idPersona = Convert.ToInt32(Request.Form["idIntroducido"]);
                Persona p = miMane.SelectPersonaBL(idPersona);
                return View("Details", p);
            }
            catch (Exception)
            {
                return View("ErrorID");
            }
        }

    }
}