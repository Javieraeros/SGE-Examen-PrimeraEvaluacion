using Ejercicio_2_DAL;
using Ejercicio_2_ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_DAL.Listados
{
    public class ListadoCategorias_DAL
    {
        /// <summary>
        /// Devuelve un listado de todas las categorías de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Categoria> selectCategorias()
        {
            Categoria miCat;
            List<Categoria> devolver = new List<Categoria>();
            MyConnection conn = new MyConnection();
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            try
            {
                //Abrimos la conexión
                conn.openConnection();

                consulta.CommandText = "Select idCategoria,nombreCategoria" +
                    " From categorias";
                consulta.Connection = conn.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miCat = new Categoria();
                        miCat.IdCategoria = (int)lector["idCategoria"];
                        miCat.NombreCategoria = (String)lector["nombreCategoria"];
                        devolver.Add(miCat);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.closeConnection();

            }
            return devolver;
        }
    }
}
