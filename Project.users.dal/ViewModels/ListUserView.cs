using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.users.dal.ViewModels
{
    public class ListUserView
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Sexo { get; set; }
    }
}
