using System.ComponentModel.DataAnnotations;

namespace SlowCoffee.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A categoria é obrigatória")]
        public string Categoria { get; set; } = string.Empty;

        [Range(1, 1000, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Range(0, 1000, ErrorMessage = "Estoque inválido")]
        public int Estoque { get; set; }
    }
}