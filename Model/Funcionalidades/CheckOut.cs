using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class CheckOut
    {
        [Key]
        public int CodCheckOut { get; set; }
        public int CodCliente { get; set; }
        public float ValorNotaFiscal { get; set; }
        [StringLength(50)]
        public string? PagamentoNotaFiscal { get; set; }
    }
}