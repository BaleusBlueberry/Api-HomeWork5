using Api_HomeWork5.DTOs;
using Api_HomeWork5.Models;
using Api_HomeWork5.DTOs;

namespace Api_HomeWork5.Mappings;

public static class ProductExtensions
{
    public static ProductResponseDto ToDto(this Product product)
    {

        return new ProductResponseDto
        {
            //Id = Guid.NewGuid().ToString(),
            ProductName = product.Name,
            Price = product.Price,
            Description = product.Description,
            Quantity = 0
        };
    }
}

