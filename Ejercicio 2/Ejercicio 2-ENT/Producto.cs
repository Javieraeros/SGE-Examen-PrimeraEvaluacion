using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_ENT
{
    public class Producto
    {
        #region Atributos
        public int IdProducto { get; set; }

        public int IdCategoria { get; set; }

        [Required,MaxLength(50)]
        public string NombreProducto { get; set; }

        #endregion

        #region Constructores

        public Producto()
        {
            this.IdProducto = 0;
            this.IdCategoria = 0;
            this.NombreProducto = "Defecto";
        }

        public Producto(int idProducto,int idCategoria,string nombreProducto)
        {
            IdProducto = idProducto;
            IdCategoria = idCategoria;
            NombreProducto = nombreProducto;
        }
        #endregion

    }
}
