using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1_ENT;
using Ejercicio_1_DAL.Manejadora;

namespace Ejercicio_1_BL.Manejadora
{
    public class Manejadora_Persona_BL
    {
        /// <summary>
        /// Método que llama a la capa DAL para recuperar una persona, introduciendo un ID
        /// </summary>
        /// <param name="id">ID de la persona a recuperar</param>
        /// <returns>Persona, o error en caso de que el id no se encuentre en la BBDD</returns>
        public Persona SelectPersonaBL(int id)
        {
            Manejadora_Persona_DAL miManejadora = new Manejadora_Persona_DAL();
            return miManejadora.selectPersonaDAL(id);
        }
    }
}
