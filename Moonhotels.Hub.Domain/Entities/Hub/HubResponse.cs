using System;
using System.Text.Json;

namespace Moonhotels.Hub.Domain.Entities.Hub
{
    public class HubResponse
    {
        public HubResponseRoom[] rooms { get; set; }

        public HubResponse()
        {
        }
        public HubResponse(HubResponseRoom[] rooms) 
        {
            this.rooms = rooms;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class HubResponseRoom
    {
        public int roomId { get; set;}
        public HubResponseRoom(int roomId) 
        {
            this.roomId = roomId;
        }

    }
}
