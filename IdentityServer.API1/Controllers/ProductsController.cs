using IdentityServer.API1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.API1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [Authorize(Policy = "ReadProduct")]
        [HttpGet]
        public IActionResult GetProducts()
        {
            var productlist = new List<Product>()
            {
                new Product { Id=1, Name="Kalem", Price=100, Stok=500 },
                new Product { Id=2, Name="Defter", Price=200, Stok=300 },
                new Product { Id=3, Name="Silgi", Price=150, Stok=400 },
                new Product { Id=4, Name="Bant", Price=550, Stok=200 }

            };
            return Ok(productlist);
        }

        [Authorize(Policy = "UpdateOrCreate")]
        public IActionResult UpdateProduct(int id)
        {
            return Ok($"id'si {id} olan ürün güncellenmiştir.");
        }
        public IActionResult CreateProduct(Product product)
        {
            return Ok(product);
        }
    }
}
