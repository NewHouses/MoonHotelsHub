using Moonhotels.Hub.Domain.Entities.Hub;
using Moonhotels.Hub.Domain.Entities.X;
using Moonhotels.Hub.Domain.Interfaces;

namespace Moonhotels.Hub.Domain.ValueObjects.X
{
    public class XRequestAdapter : IRequestAdapter
    {
        public readonly HubRequest hubRequest;

        public XRequestAdapter(HubRequest hubRequest)
        {
            this.hubRequest = hubRequest;
        }

        public IRequest Convert()
        {
            /*
             Facemos algo co hubRquest
             */

            return new XRequest();
        }

        public string ToJson()
        {
            var xRequest = Convert();
            return xRequest.ToJson();
        }
    }
}
