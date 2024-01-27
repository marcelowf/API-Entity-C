using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Frigobar
    {
        [Key]
        public int CodFrigobar { get; set; }
        [StringLength(50)]
        public string? NomeFrigobar { get; set; }
    }
}
