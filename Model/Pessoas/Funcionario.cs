using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Funcionario
    {
        [Key]
        public int CodFuncionario { get; set; }
        [StringLength(50)]
        public string? TipoFuncionario { get; set; }
        [StringLength(50)]
        public string? Cargo { get; set; }
    }
}