using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class ConsumoFrigobar
    {
        [Key]
        public int CodConsumoFrigobar { get; set; }
        public int CodCliente { get; set; }
        public int CodFrigobar { get; set; }
        public int CodNotaFiscal { get; set; }
        [StringLength(150)]
        public string? DescricaoConsumo { get; set; }
        public float ValorConsumo { get; set; }
        public bool Assinado { get; set; }
    }
}