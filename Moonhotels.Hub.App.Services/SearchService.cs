using Moonhotels.Hub.App.Services.InfrastructureInterfaces;
using Moonhotels.Hub.Domain.Services;
using Moonhotels.Hub.Domain.Services.Factories;

namespace Moonhotels.Hub.App.Services
{
    public class SearchService
    {
        private IHotelLegsApi hotelLegsApi;
        private IConnector hotelLegsConnector;

        private IXApi xApi;
        private IConnector xConnector;

        public SearchService(IHotelLegsApi hotelLegsApi, IXApi xApi)
        {
            this.hotelLegsApi = hotelLegsApi;
            this.hotelLegsConnector = new Connector(new HotelLegsAdapterFactory());
            this.xApi = xApi;   
            this.xConnector = new Connector(new XAdapterFactory());
        }

        public string[] Search(string hubRequestJson)
        {
            var hotelLegsResponse = GetApiResponse(hubRequestJson, hotelLegsConnector,  hotelLegsApi);
            var xResponse = GetApiResponse(hubRequestJson, xConnector, xApi);

            return new[] { hotelLegsResponse, xResponse };
        }

        private string GetApiResponse(string hubRequestJson, IConnector connector, IApi api)
        {
            var hotelLegsRequestJson = connector.TransformRequest(hubRequestJson);
            var apiResponse = api.GetResponse(hotelLegsRequestJson);
            return connector.TransformResponse(apiResponse);
        }


    }
}
