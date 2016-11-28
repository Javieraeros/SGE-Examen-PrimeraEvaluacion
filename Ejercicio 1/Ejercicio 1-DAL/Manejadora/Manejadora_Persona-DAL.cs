using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1_ENT;
using Ejercicio_1_DAL.Conexion;

namespace Ejercicio_1_DAL.Manejadora
{
    public class Manejadora_Persona_DAL
    {
        //Aunque no es necesario tener una propiedad aquí, la pongo por si tengo qeu añadir algún método que le haga falta
        MyConnection miCon = new MyConnection();

        /// <summary>
        /// Método que nos devuelve lso detalles de una persona al pasarle el id
        /// </summary>
        /// <param name="id">Id de persona para ver sus detalles</param>
        /// <returns>La persona seleccionada o lanza un error si el id es incorrecto(capturar en capa UI)</returns>
        public Persona selectPersonaDAL(int id)
        {
            Persona p = new Persona();
            SqlCommand miCommand = new SqlCommand();
            SqlDataReader lector;
            try
            {
                miCon.openConnection();
                miCommand.Connection = miCon.connection;
                miCommand.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                miCommand.CommandText = "Select nombre,apellidos,fechaNac,direccion,telefono from Personas where id=@id";
                lector = miCommand.ExecuteReader();

                lector.Read();
                p.id = id;
                p.Nombre = (String)lector["nombre"];
                p.Apellidos = (String)lector["apellidos"];
                p.FechaNac = (DateTime)lector["fechaNac"];
                p.direccion = (String)lector["direccion"];
                p.telefono = (String)lector["telefono"];
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                miCon.closeConnection();
            }

            return p;
        }
    }
}
