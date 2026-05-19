using System.ComponentModel.DataAnnotations;

namespace SlowCoffee.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required]
        public string Cliente { get; set; } = string.Empty;

        [Required]
        public string Produto { get; set; } = string.Empty;

        [Range(1, 100)]
        public int Quantidade { get; set; }

        public decimal ValorTotal { get; set; }
    }
}