using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSMediaTrFrancisTest.RequestModels.QueryRequestModels;
using CQRSMediaTrFrancisTest.ResponseModels.QueryResponseModels;

namespace CQRSMediaTrFrancisTest.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {
        GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel);
    }
}
