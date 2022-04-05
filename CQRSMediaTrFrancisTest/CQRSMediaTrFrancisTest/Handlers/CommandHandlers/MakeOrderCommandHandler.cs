using System;
using System.Threading;
using System.Threading.Tasks;
using CQRSMediaTrFrancisTest.RequestModels.CommandRequestModels;
using CQRSMediaTrFrancisTest.ResponseModels.CommandResponseModels;
using MediatR;

namespace CQRSMediaTrFrancisTest.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IRequestHandler<MakeOrderRequestModel, MakeOrderResponseModel>
    {
        public async Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request, CancellationToken cancellationToken)
        {
            var result = new MakeOrderResponseModel
            {
                IsSuccess = true,
                OrderId = new Guid("43d26807-ad70-4449-8479-024c54eb2006")
            };
            // Your business logic here

            return result;
        }
    }
}
