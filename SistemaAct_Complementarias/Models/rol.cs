using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SistemaAct_Complementarias.Models
{
    public class rol
    {
        [Key]

        [Required(ErrorMessage = "Campo Requerido")]
        public int idrol { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe de tener de 3 a 50 caracteres")]
        public string Nombres { get; set; }

        [StringLength(250, MinimumLength = 10, ErrorMessage = "La Descripcion es incorrecto, favor de completar tu direccion")]
        public string Descripcion { get; set; }

     
    }
}
