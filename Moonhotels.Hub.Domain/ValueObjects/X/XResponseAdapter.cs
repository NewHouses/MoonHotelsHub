using Moonhotels.Hub.Domain.Entities.HotelLegs;
using Moonhotels.Hub.Domain.Entities.Hub;
using Moonhotels.Hub.Domain.Interfaces;

namespace Moonhotels.Hub.Domain.ValueObjects.X
{
    public class XResponseAdapter : IResponseAdapter
    {
        public readonly HotelLegsResponse xResponse;

        public XResponseAdapter(HotelLegsResponse xResponse)
        {
            this.xResponse = xResponse;
        }

        public HubResponse Convert()
        {
            /*
             Facemos algo co hotelLegsResponse
             */
            return new HubResponse();
        }

        public string ToJson()
        {
            var xResponse = Convert();
            return xResponse.ToJson();
        }
    }
}
