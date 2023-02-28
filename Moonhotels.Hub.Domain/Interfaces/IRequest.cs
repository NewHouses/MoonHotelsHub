using System.Text.Json;

namespace Moonhotels.Hub.Domain.Interfaces
{
    public interface IRequest
    {
        public string ToJson();
    }
}
