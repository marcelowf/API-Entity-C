using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Reserva
    {
        [Key]
        public int CodReserva { get; set; }
        public DateTime DtReserva { get; set; }
        [StringLength(50)]
        public string? TipoReserva { get; set; }
        [StringLength(50)]
        public string? StatusReserva { get; set; }
    }
}
