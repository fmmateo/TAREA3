using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Prestamos.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo {0} es Obligatorio ")]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="Este campo {0} es Obligatorio")]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required(ErrorMessage ="Este campo {0} es Obligatorio")]
        [StringLength(200)]
        public string Direccion { get; set; }

        [Required(ErrorMessage ="Este campo {0} es Obligatorio")]
        [StringLength(18)]
        public string Telefono { get; set; }

        [Required(ErrorMessage ="Este campo {0} es Obligatorio")]
        [StringLength(100)]
        public string Correo { get; set; }

        //public virtual:es para indicar que es una clave foranea
        //el ICollection sirve como un arreglo para ir agregando las referencia que se hacen a nuestra clave foranea
        public virtual ICollection<Prestamo> Prestamo { get; set; }

    }
}