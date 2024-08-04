using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Api_HomeWork5.Models
{
    public class Product
    {
        /*[BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]*/
        public string? Id { get; set; }

        [Required, MinLength(2), MaxLength(30)]
        public required string Name { get; set; }

        [Required, MinLength(2), MaxLength(256)]
        public required string Description { get; set; }

        [Required, Range(0, 99999)]
        public decimal Price { get; set; }

        [Required, Range(0, int.MaxValue)]
        public required int Quantity { get; set; }
    }
}
