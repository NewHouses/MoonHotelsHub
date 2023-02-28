using Moonhotels.Hub.Domain.Interfaces;
using System.Text.Json;

namespace Moonhotels.Hub.Domain.Entities.X
{
    public class XResponse : IResponse
    {

        public XResponse() { }

        public IResponse FromJson(string hotelLegsResponseJson)
        {
            return JsonSerializer.Deserialize<XResponse>(hotelLegsResponseJson);
        }
    }
}
