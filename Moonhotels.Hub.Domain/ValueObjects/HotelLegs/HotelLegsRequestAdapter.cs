using Moonhotels.Hub.Domain.Entities.HotelLegs;
using Moonhotels.Hub.Domain.Entities.Hub;
using Moonhotels.Hub.Domain.Interfaces;

namespace Moonhotels.Hub.Domain.ValueObjects.HotelLegs
{
    public class HotelLegsRequestAdapter : IRequestAdapter
    {
        public readonly HubRequest hubRequest;

        public HotelLegsRequestAdapter(HubRequest hubRequest)
        {
            this.hubRequest = hubRequest;
        }

        public IRequest Convert()
        {
            /*
             Facemos algo co hubRquest
             */

            return new HotelLegsRequest(hubRequest.hotelId);
        }

        public string ToJson()
        {
            var hotelLegsRequest = Convert();
            return hotelLegsRequest.ToJson();
        }
    }
}
