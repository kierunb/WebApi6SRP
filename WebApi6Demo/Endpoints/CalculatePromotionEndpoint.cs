using MediatR;
using WebApi6Demo.Services;

namespace WebApi6Demo.Endpoints;

// dane wejsciowe dla enpointa
public class PromotionProduct : IRequest<PromotionResponse>
{
    public int ID { get; set; }
    public string ProductName { set; get; } = "";
}

// dane wysciowe dla enpointa
public class PromotionResponse
{
    public double Promotion { get; set; }
    public DateTime CalculationDate { get; set; }
}


// Handler
public class CalculatePromotionEndpoint :
    IRequestHandler<PromotionProduct, PromotionResponse>
{
    private readonly IProductCalculationService _productCalculationService;

    public CalculatePromotionEndpoint(
        IProductCalculationService productCalculationService)
    {
        _productCalculationService = productCalculationService;
    }
    
    public async Task<PromotionResponse> Handle(PromotionProduct request, CancellationToken cancellationToken)
    {
        await Task.Delay(1);

        var promotion = _productCalculationService.Calculate(request.ProductName);

        return new PromotionResponse { 
            Promotion = promotion, 
            CalculationDate = DateTime.Now 
        };
    }
}
