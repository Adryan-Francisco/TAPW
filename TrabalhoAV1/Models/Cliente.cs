using System.ComponentModel.DataAnnotations;

namespace TrabalhoAV1.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateOnly DateOnly { get; set; }  
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}