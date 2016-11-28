using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_ENT
{
    public class Categoria
    {
        #region Atributos
        public int IdCategoria { get; set; }

        [Required, MaxLength(50)]
        public string NombreCategoria { get; set; }
        #endregion

        #region Constructores
        public Categoria()
        {
            IdCategoria = 0;
            NombreCategoria = "Defecto";
        }

        public Categoria(int idCategoria,string nombreProducto)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreProducto;
        }
        #endregion
    }
}
