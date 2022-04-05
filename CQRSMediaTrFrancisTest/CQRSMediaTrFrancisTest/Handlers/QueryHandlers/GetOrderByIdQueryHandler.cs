using System.Threading;
using System.Threading.Tasks;
using CQRSMediaTrFrancisTest.RequestModels.QueryRequestModels;
using CQRSMediaTrFrancisTest.ResponseModels.QueryResponseModels;
using MediatR;

namespace CQRSAndMediator.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, GetOrderByIdResponseModel>
    {
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            var orderDetails = new GetOrderByIdResponseModel();
            // Your logic here
            return orderDetails;
        }
    }
}