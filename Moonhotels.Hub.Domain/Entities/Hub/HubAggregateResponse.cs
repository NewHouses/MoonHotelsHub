using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moonhotels.Hub.Domain.Entities.Hub
{
    public class HubAggregateResponse
    {
        public IEnumerable<HubResponse> Responses { get; set; }
        public HubAggregateResponse() { }
    }
}
