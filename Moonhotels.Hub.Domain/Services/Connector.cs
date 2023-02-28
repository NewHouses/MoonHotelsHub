using Moonhotels.Hub.Domain.Interfaces;

namespace Moonhotels.Hub.Domain.Services
{
    public class Connector : IConnector
    {
        private IAdapterFactory adapterFactory;
        public Connector(IAdapterFactory adapterFactory) { 
            this.adapterFactory = adapterFactory;
        }

        public string TransformRequest(string hubRequestJson)
        {
            var RequestAdapter = GetRequestAdapter(hubRequestJson);
            return TransformToApiRequest(RequestAdapter);
        }

        public string TransformResponse(string apiResponse)
        {
            var RequestAdapter = GetResponseAdapter(apiResponse);
            return TransformToHubResponse(RequestAdapter);
        }

        private IRequestAdapter GetRequestAdapter(string hubRequestJson)
        {
            return adapterFactory.CreateRequestAdapter(hubRequestJson);
        }

        private IResponseAdapter GetResponseAdapter(string apiResponse)
        {
            return adapterFactory.CreateResponseAdapter(apiResponse);
        }

        private string TransformToApiRequest(IRequestAdapter requestAdapter)
        {
            return requestAdapter.ToJson();
        }

        private string TransformToHubResponse(IResponseAdapter responseAdapter)
        {
            return responseAdapter.ToJson();
        }
    }
}
