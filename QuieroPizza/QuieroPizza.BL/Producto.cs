using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
   public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int id { get; set; }

        [Required(ErrorMessage = "Ingrese la descripcion")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 caracteres")]
        [MaxLength(20, ErrorMessage = "Ingrese maximo 20 caracteres")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese el precio")]
        [Range(0,1000,ErrorMessage = "Ingrese el precio entre 0 y 1000")]
        public double precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }
    }
}
