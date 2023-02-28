using Moonhotels.Hub.Domain.Interfaces;
using System.Text.Json;

namespace Moonhotels.Hub.Domain.Entities.HotelLegs
{
    public class HotelLegsRequest : IRequest
    {
        public int hotel { get; set; }
        public HotelLegsRequest(int hotel)
        {
            this.hotel = hotel;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
