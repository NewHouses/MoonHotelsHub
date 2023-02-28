using Moonhotels.Hub.Domain.Entities.HotelLegs;
using Moonhotels.Hub.Domain.Entities.Hub;
using Moonhotels.Hub.Domain.Interfaces;

namespace Moonhotels.Hub.Domain.ValueObjects.HotelLegs
{
    public class HotelLegsResponseAdapter : IResponseAdapter
    {
        public readonly HotelLegsResponse hotelLegsResponse;

        public HotelLegsResponseAdapter(HotelLegsResponse hotelLegsResponse)
        {
            this.hotelLegsResponse = hotelLegsResponse;
        }

        public HubResponse Convert()
        {
            /*
             Facemos algo co hotelLegsResponse
             */
            var rooms = hotelLegsResponse.results.GroupBy(result => result.room);
            var hubResponseRooms = new List<HubResponseRoom>();
            foreach (var room in rooms)
            {
                var hubResponseRoom = new HubResponseRoom(room.Key);
                hubResponseRooms.Add(hubResponseRoom);
            }
            return new HubResponse(hubResponseRooms.ToArray());
        }

        public string ToJson()
        {
            var hotelLegsResponse = Convert();
            return hotelLegsResponse.ToJson();
        }
    }
}
