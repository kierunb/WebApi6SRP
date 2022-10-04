

using MediatR;

namespace WebApi6Demo.Endpoints;


public class AddPromotionRequest : IRequest<AddPromotionResponse>
{
    public int MyProperty { get; set; }
}

public class AddPromotionResponse
{
    public int MyProperty { get; set; }
}


public class AddPropmotionEndpoint
    : IRequestHandler<AddPromotionRequest, AddPromotionResponse>
{
    public AddPropmotionEndpoint()
    {

    }
    
    public Task<AddPromotionResponse> Handle(AddPromotionRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
