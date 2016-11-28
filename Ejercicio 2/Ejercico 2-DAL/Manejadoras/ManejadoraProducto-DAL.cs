using Ejercicio_2_DAL;
using Ejercicio_2_ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_DAL
{
    public class ManejadoraProducto_DAL
    {
        /// <summary>
        /// Método que inserta un producto en la base de datos.
        /// En caso de que no pueda insertarlo por algún tipo de error, devolverá 0. 
        /// 1 en caso contrario
        /// </summary>
        /// <param name="p">Producto a insertar</param>
        /// <returns></returns>
        public int insertaProducto(Producto p)
        {
            int filasInsertadas = 1;
            MyConnection miCon = new MyConnection();

            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int).Value = p.IdCategoria;
            miComando.Parameters.Add("@nombreProducto", System.Data.SqlDbType.VarChar).Value = p.NombreProducto;

            try
            {
                miCon.openConnection();

                miComando.CommandText = "Insert Into productos(idCategoria,nombreProducto) VALUES "
                    + "(@idCategoria,@nombreProducto)";
                miComando.Connection = miCon.connection;
                filasInsertadas = miComando.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                filasInsertadas = 0;
            }
            finally
            {
                miCon.closeConnection();
            }

            return filasInsertadas;
        }
    }
}
