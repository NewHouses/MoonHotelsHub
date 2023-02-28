namespace Moonhotels.Hub.Domain.Services
{
    public interface IConnector
    {
        public string TransformRequest(string hubRequestJson);

        public string TransformResponse(string apiResponse);
    }
}
