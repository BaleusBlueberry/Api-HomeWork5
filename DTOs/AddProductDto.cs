using System.ComponentModel.DataAnnotations;

namespace Api_HomeWork5.DTOs
{
    public class AddProductDto
    {

        [Required, MinLength(2), MaxLength(30)]
        public string Name { get; set; }

        [Required, MinLength(2), MaxLength(30)]
        public string Description { get; set; }

        [Required, Range(0, 99999)]
        public decimal Price { get; set; }
    }
}
