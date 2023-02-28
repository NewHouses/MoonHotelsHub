using System.Text.Json;

namespace Moonhotels.Hub.Domain.Entities.Hub
{
    public class HubRequest
    {
        public int hotelId { get; set; }

        public static HubRequest FromJson(string hubRequestJson)
        {
            return JsonSerializer.Deserialize<HubRequest>(hubRequestJson);
        }
    }
}
