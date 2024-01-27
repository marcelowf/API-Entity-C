using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Quarto
    {
        [Key]
        public int CodQuarto { get; set; }
        [StringLength(10)]
        public string? Adaptado { get; set; }
        [StringLength(50)]
        public string? TipoQuarto { get; set; }
        public int CapacidadeMaxima { get; set; }
        public int CapacidadeOpcional { get; set; }
        public float ValorDiaria { get; set; }
        public int CodFilial { get; set; }
    }
}