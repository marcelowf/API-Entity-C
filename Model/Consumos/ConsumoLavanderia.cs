using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class ConsumoLavanderia
    {
        [Key]
        public int CodConsumoLavanderia { get; set; }
        public int CodCliente { get; set; }
        public int CodLavanderia { get; set; }
        public int CodNotaFiscal { get; set; }
        public int QuantidadeServicos { get; set; }
        public float ValorConsumo { get; set; }
        public bool Assinado { get; set; }
    }
}
