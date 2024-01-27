using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Checkin
    {
        [Key]
        public int CodCheckin { get; set; }
        public int CodCliente { get; set; }
        public string? StatusCheckIn { get; set; }
        public int PeriodoPermanecia { get; set; }
    }
}
