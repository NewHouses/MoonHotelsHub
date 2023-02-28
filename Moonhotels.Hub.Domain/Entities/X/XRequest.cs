using Moonhotels.Hub.Domain.Interfaces;
using System.Text.Json;

namespace Moonhotels.Hub.Domain.Entities.X
{
    public class XRequest : IRequest
    {
        public XRequest()
        {
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
