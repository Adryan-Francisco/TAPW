using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrabalhoAV1.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; }
        public ICollection<Cidade>? Cidades { get; set; }
    }
}