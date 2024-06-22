using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CRUD_Mvvm_2.Models
{
    public class Proveedor

    {

        public int Id { get; set; }

        [Required]

        public string Nombre { get; set; }

        [Required]

        public string Apellido { get; set; }

        [Required]

        public string Direccion { get; set; }

        [Required]

        public string Telefono { get; set; }

        [Required]

        public string Email { get; set; }

    }
}
