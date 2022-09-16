using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.users.dal.ViewModels
{
   public class CreateUser
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        [Required]
        public Sexo Sexo { get; set; }
    }
}
