using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Hotel
    {
        [Key]
        public int CodHotel { get; set; }
        [StringLength(50)]
        public string? NomeHotel { get; set; }
        public ICollection<Filial>? Filiais { get; set; }
    }
}