using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = new[]
            {
                new { Id = 101, Name = "Laptop" },
                new { Id = 102, Name = "Smartphone" }
            };

            var client = _httpClientFactory.CreateClient();
            var userResponse = await client.GetFromJsonAsync<object>("http://userservice/api/users");

            return Ok(new
            {
                Products = products,
                Users = userResponse
            });
        }
    }
}
