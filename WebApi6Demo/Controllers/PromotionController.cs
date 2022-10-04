using Microsoft.AspNetCore.Mvc;
using WebApi6Demo.Services;

namespace WebApi6Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IProductCalculationService _productCalculationService;

        public PromotionController(
            IProductCalculationService productCalculationService)
        {
            _productCalculationService = productCalculationService;
        }
        
        [HttpGet("calculate")]
        public IActionResult Calculate(string product)
        {
            
           var promotion = _productCalculationService.Calculate(product);

           return Ok(promotion);
        }
    }
}
