using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Filial
    {
        [Key]
        public int CodFilial { get; set; }
        [StringLength(50)]
        public string? NomeFilial { get; set; }
        public int NumQuartosLuxo { get; set; }
        public int NumQuartosExecutivo { get; set; }
        public int NumQuartosEconomico { get; set; }
        [StringLength(100)]
        public string? EnderecoFilial { get; set; }
        public int Estrelas { get; set; }
        public ICollection<Quarto>? Quartos { get; set; }
        public Hotel? Hotel { get; set; }
    }
}