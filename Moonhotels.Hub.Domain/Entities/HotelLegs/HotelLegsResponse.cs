using Moonhotels.Hub.Domain.Interfaces;
using System.Text.Json;

namespace Moonhotels.Hub.Domain.Entities.HotelLegs
{
    public class HotelLegsResponse : IResponse
    {
        public HotelLegsResponseResult[] results { get; set; }

        public HotelLegsResponse() { }

        public static HotelLegsResponse FromJson(string hotelLegsResponseJson)
        {
            return JsonSerializer.Deserialize<HotelLegsResponse>(hotelLegsResponseJson);
        }
    }

    public class HotelLegsResponseResult
    {
        public int room { get; set; }
    }
}
