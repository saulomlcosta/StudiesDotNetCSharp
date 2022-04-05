using CQRSMediaTrFrancisTest.RequestModels.CommandRequestModels;
using CQRSMediaTrFrancisTest.ResponseModels.CommandResponseModels;

namespace CQRSMediaTrFrancisTest.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel);
    }
}
