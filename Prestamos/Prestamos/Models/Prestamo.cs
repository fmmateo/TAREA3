using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prestamos.Models
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="Este campo {0} es Obligatorio")]
        public long Monto { get; set; }


        [Required(ErrorMessage ="Este campo {0} es Obligatorio")]
        public decimal Interes{ get; set; }


        [Required(ErrorMessage ="Este campo {0} es Obligatorio")]
        public decimal Periodo{ get; set; }

        //get para mostrarlo o obtenerlo
        //set para incertar o agregar un valor
        public int ClientesId { get; set; }

        public virtual Clientes Clientes {get; set;}

    }
}