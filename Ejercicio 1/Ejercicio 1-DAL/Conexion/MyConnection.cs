using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

// Esta clase contiene los métodos necesarios para trabajar con el acceso a una base de datos SQL Server
//PROPIEDADES
//   _database: cadena, básica. Consultable/modificable.
//   _user: cadena, básica. Consultable/modificable.
//   _pass: cadena, básica. Consultable/modificable.

// MÉTODOS
//   Function getConnection() As SqlConnection
//       Este método abre una conexión con la base de datos. Lanza excepciones de tipo: SqlExcepion, InvalidOperationException y Exception.
//   
//   Sub closeConnection(ByRef connection As SqlConnection)
//       Este método cierra una conexión con la base de datos. Lanza excepciones de tipo: SqlExcepion, InvalidOperationException y Exception.
//


namespace Ejercicio_1_DAL.Conexion

{
    public class MyConnection
    {
        #region Atributos
        public String host { get; set; }
        public String dataBase { get; set; }
        public String user { get; set; }
        public String pass { get; set; }

        public SqlConnection connection { get; set; }

        #endregion

        #region Constructores

        public MyConnection()
        {
            this.host = "localhost";
            this.dataBase = "WPFSample";
            this.user = "prueba";
            this.pass = "123";


        }
        //Con parámetros por si quisiera cambiar las conexiones
        public MyConnection(String host,String database, String user, String pass)
        {
            this.host = host;
            this.dataBase = database;
            this.user = user;
            this.pass = pass;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método que abre una conexión con la base de datos
        /// </summary>
        /// <pre>Nada.</pre>
        /// <returns>Nada</returns>
        public void openConnection()
        {
            connection = new SqlConnection();
            try
            {
                //Muy cómoda esta forma de escribir la cadena conStringFormat, metiendo los parametros entre llaves y asignandoselo tras la coma
                connection.ConnectionString = string.Format("server={0};database={1};uid={2};pwd={3};",host, dataBase, user, pass);
                connection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

        }


        /// <summary>
        /// Este metodo cierra una conexión con la Base de datos
        /// </summary>
        /// <post>The connection is closed.</post>
        /// <param name="connection">La entrada es la conexión a cerrar
        /// </param>
        public void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw; 
            }
            catch (Exception)
            {
            throw;
            }
        }

        #endregion

    }

}
