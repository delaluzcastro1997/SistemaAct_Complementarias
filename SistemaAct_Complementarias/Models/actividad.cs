using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaAct_Complementarias.Models
{
    public class actividad
    {
        [Key]
        public int idactividad { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe de tener de 3 a 50 caracteres")]
        public string Nombres { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apellido paterno debe de tener de 3 a 50 caracteres")]
        public string objetivoGeneral { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apelliodo materno debe de tener de 3 a 50 caracteres")]
        public string competencia { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        public int Edad { get; set; }

        [StringLength(10, MinimumLength = 10, ErrorMessage = "El numero de telefono debe contener 10 digitos")]
        public string temario { get; set; }

        [StringLength(250, MinimumLength = 10, ErrorMessage = "La Autorizacion no es incorrecto, favor de completar tu autorizacion")]
        public string autorizada { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "El numero de Creditos no es la correcta, introduce los creditos correctos completa")]
        public string nocreditos { get; set; }

        public int usuario_idusuario { get; set; }

        public int periodo_idperiodo { get; set; }

        public int organigrama { get; set; }
    }
}
