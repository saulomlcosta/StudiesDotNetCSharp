using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSMediaTrFrancisTest.ResponseModels.QueryResponseModels;
using MediatR;

namespace CQRSMediaTrFrancisTest.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel : IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
