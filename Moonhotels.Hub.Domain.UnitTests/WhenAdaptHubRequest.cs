using Moonhotels.Hub.Domain.Entities.HotelLegs;
using Moonhotels.Hub.Domain.Entities.Hub;
using Moonhotels.Hub.Domain.ValueObjects.HotelLegs;

namespace Moonhotels.Hub.Domain.UnitTests
{
    public class WhenAdaptHubRequest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToHubRequestEntity()
        {
            var hubRequestJson = "{\"hotelId\":1}";
            var hubRequest = HubRequest.FromJson(hubRequestJson);

            Assert.That(hubRequest.hotelId, Is.EqualTo(1));
        }

        [Test]
        public void ToHotelLegsRequestEntity()
        {
            var hubRequestJson = "{\"hotelId\":1}";
            var expectedHotelLegsRequestJson = "";

            var hubRequest = HubRequest.FromJson(hubRequestJson);
            var hotelLegsRequest = new HotelLegsRequestAdapter(hubRequest).Convert() as HotelLegsRequest;

            Assert.That(hotelLegsRequest.hotel, Is.EqualTo(1));
        }

        [Test]
        public void ToHotelLegsRequestJson()
        {
            var hubRequestJson = "{\"hotelId\":1}";
            var expectedHotelLegsRequestJson = "{\"hotel\":1}";

            var hubRequest = HubRequest.FromJson(hubRequestJson);
            var hotelLegsRequestJson = new HotelLegsRequestAdapter(hubRequest).ToJson();

            Assert.That(hotelLegsRequestJson, Is.EqualTo(expectedHotelLegsRequestJson));
        }
    }
}