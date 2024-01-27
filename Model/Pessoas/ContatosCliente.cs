using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class ContatosCliente
    {
        [Key]
        public int CodContato { get; set; }
        public int CodCliente { get; set; }
        [StringLength(50)]
        public string? TelefoneContato { get; set; }
        [StringLength(50)]
        public string? EnderecoContato { get; set; }
    }
}

