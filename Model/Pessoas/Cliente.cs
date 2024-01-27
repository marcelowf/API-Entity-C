using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Cliente
    {
        [Key]
        public int CodCliente { get; set; }
        [StringLength(50)]
        public string? NomeCliente { get; set; }
        [StringLength(50)]
        public string? EmailCliente { get; set; }
        [StringLength(50)]
        public string? NacionalidadeCliente { get; set; }
        public ICollection<ContatosCliente>? Contatos { get; set; }
    }
}
