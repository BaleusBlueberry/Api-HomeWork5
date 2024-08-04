using Api_HomeWork5.DTOs;
using Api_HomeWork5.Models;

namespace Api_HomeWork5.Mappings
{
    public static class AddProductDtoExtensions

    {
        // from AddProductDto to Product 
        public static Product ToProduct(this AddProductDto dto)
        {
            return new Product()
            {
                //Id = Guid.NewGuid().ToString(),
                Name = dto.Name,
                Price = dto.Price,
                Description = dto.Description,
                Quantity = 0
            };
        }

    }
}
