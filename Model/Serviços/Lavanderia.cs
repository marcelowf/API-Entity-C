using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Lavanderia
    {
        [Key]
        public int CodLavanderia { get; set; }
        [StringLength(50)]
        public string? NomeServico { get; set; }
    }
}