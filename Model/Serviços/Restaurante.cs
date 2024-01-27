using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Restaurante
    {
        [Key]
        public int CodRestaurante { get; set; }
        [StringLength(50)]
        public string? NomeRestaurante { get; set; }
    }
}
