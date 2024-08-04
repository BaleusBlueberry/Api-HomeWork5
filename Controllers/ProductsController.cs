using Api_HomeWork5.DTOs;
using Api_HomeWork5.Mappings;
using Api_HomeWork5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Api_HomeWork5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // prop
        private static List<Product> products = [];

        [HttpPost]
        public IActionResult PostItem(AddProductDto item)
        {
            products.Add(item.ToProduct());
            return Ok(item);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products.Select(p => p.ToDto()));
        }

        [HttpDelete]
        public IActionResult Delete(string name)
        {
            var Product = products.Find(p => p.Name == name);

            if (Product != null)
            {
                products.Remove(Product);
                return Ok();
            }

            return NotFound();
        }
    }

    
}
