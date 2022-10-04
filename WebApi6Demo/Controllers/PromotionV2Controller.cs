using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi6Demo.Endpoints;

namespace WebApi6Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionV2Controller : ControllerBase
    {
        private readonly IMediator _mediator;

        public PromotionV2Controller(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        
        [HttpPost("calculate")]
        public async Task<IActionResult> Calculate(PromotionProduct product)
        {

            var response = await _mediator.Send(product);
            
            return Ok(response.Promotion);
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add(AddPromotionRequest product)
        {
            var response = await _mediator.Send(product);
            return Ok();
        }
    }
}
