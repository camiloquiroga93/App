using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppV.Models
{
    public class Empleado
    {   [Key]
        public int Id { get; set; }

        [Display(Name ="Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="Ingrese  nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Display(Name ="Apellido")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese apellido")]
        [StringLength(50)]
        public string Apellido { get; set; }

        public string DNI { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Edad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una edad")]
        [Range(18,99,ErrorMessage ="Ingrese una edad entre 18 a 99 años")]
        public string Edad { get; set; }

        [EmailAddress]
        public string Email { get; set;  }

        
        public string Celular { get; set; }

    }
}
