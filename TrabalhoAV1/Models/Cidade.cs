using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrabalhoAV1.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
        public ICollection<Cliente>? Clientes { get; set; }
    }
}