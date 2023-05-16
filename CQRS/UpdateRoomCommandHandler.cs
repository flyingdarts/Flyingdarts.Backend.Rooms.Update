using Amazon.Lambda.APIGatewayEvents;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, APIGatewayProxyResponse>
{
    public UpdateRoomCommandHandler()
    {
    }
    public async Task<APIGatewayProxyResponse> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
    {
        return new APIGatewayProxyResponse { StatusCode = 200 };
    }
}