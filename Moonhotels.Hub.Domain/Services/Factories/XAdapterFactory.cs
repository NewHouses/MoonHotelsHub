using Moonhotels.Hub.Domain.Entities.HotelLegs;
using Moonhotels.Hub.Domain.Entities.Hub;
using Moonhotels.Hub.Domain.Interfaces;
using Moonhotels.Hub.Domain.ValueObjects;
using Moonhotels.Hub.Domain.ValueObjects.X;

namespace Moonhotels.Hub.Domain.Services.Factories
{
    public class XAdapterFactory : IAdapterFactory
    {
        public IRequestAdapter CreateRequestAdapter(string hubRequestJson)
        {
            var hubRequest = HubRequest.FromJson(hubRequestJson);
            return new XRequestAdapter(hubRequest);
        }

        public IResponseAdapter CreateResponseAdapter(string apiResponse)
        {
            var hotelLegResponse = HotelLegsResponse.FromJson(apiResponse);
            return new XResponseAdapter(hotelLegResponse);
        }
    }
}
