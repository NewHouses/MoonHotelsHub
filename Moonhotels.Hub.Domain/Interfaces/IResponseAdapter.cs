using Moonhotels.Hub.Domain.Entities.Hub;

namespace Moonhotels.Hub.Domain.Interfaces
{
    public interface IResponseAdapter
    {
        public HubResponse Convert();

        public string ToJson();
    }
}
