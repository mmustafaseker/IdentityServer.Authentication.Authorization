using IdentityServer.API2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.API2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetPictures()
        {
            var pictures = new List<Picture>()
            {
                new Picture { Id=1, Name = "Doğa Resmi", Url = "dogaresmi.jpg"},
                new Picture { Id=2, Name = "fil Resmi", Url = "filresmi.jpg"},
                new Picture { Id=3, Name = "aslan Resmi", Url = "aslanresmi.jpg"},
                new Picture { Id=4, Name = "kaplan Resmi", Url = "kaplanresmi.jpg"},
                new Picture { Id=5, Name = "kedi Resmi", Url = "kediresmi.jpg"},
                new Picture { Id=6, Name = "civciv Resmi", Url = "civcivresmi.jpg"}
            };
            return Ok(pictures);
        }
    }
}
