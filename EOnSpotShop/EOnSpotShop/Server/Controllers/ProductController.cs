using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EOnSpotShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id= 1,
                Title = "Biochemistry (book)",
                Description = "Biochemistry is a common university textbook used for teaching of biochemistry. It was initially written by Lubert Stryer and published by W. H. Freeman in 1975.[1][2][3] It has been published in regular editions since.[4][5][6] It is commonly used as an undergraduate teaching textbook or reference work.[7]",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Bretherick_3_to_7_eds.jpg/300px-Bretherick_3_to_7_eds.jpg",
                Price = 7.98m
            },
            new Product
            {
                Id = 2,
                Title = "The Debian System",
                Description = "The Debian System is a 2005 non-fiction book written by Martin Krafft which deals exclusively with Debian Linux, detailing its internal workings. The book is mostly for the experienced users seeking in-depth technical knowledge, rather than for beginners.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/57/Debian_System_Cover.png",
                Price = 8.02m
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(products);
        }
    }
}
