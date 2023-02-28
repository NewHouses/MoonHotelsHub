namespace Moonhotels.Hub.Domain.Interfaces
{
    public interface IAdapterFactory
    {
        public IRequestAdapter CreateRequestAdapter(string hubRequestJson);

        public IResponseAdapter CreateResponseAdapter(string apiResponse);
    }
}
