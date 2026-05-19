using System.ComponentModel.DataAnnotations;

namespace SlowCoffee.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O telefone é obrigatório")]
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; } = string.Empty;
    }
}