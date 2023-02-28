using Moonhotels.Hub.Domain.Entities;
using Moonhotels.Hub.Domain.Entities.HotelLegs;
using Moonhotels.Hub.Domain.ValueObjects;
using Moonhotels.Hub.Domain.ValueObjects.HotelLegs;

namespace Moonhotels.Hub.Domain.UnitTests
{
    public class WhenAdaptHotelLegsResponse
    {

        [Test]
        public void ToHotelLegsResponseEntity()
        {
            var hotelLegsResponseJson = "{\"results\":[{\"room\":1}]}";

            var hotelLegResponse = HotelLegsResponse.FromJson(hotelLegsResponseJson);

            Assert.That(hotelLegResponse.results.Length, Is.EqualTo(1));
            Assert.That(hotelLegResponse.results[0].room, Is.EqualTo(1));
        }

        [Test]
        public void ToHubResponseEntity()
        {
            var hotelLegsResponseJson = "{\"results\":[{\"room\":1}]}";
            //var expectedHubResponseJson = "\"rooms\":[\"roomId\":1]}";

            var hotelLegResponse = HotelLegsResponse.FromJson(hotelLegsResponseJson);
            var hubResponse = new HotelLegsResponseAdapter(hotelLegResponse).Convert();

            Assert.That(hubResponse.rooms.Length, Is.EqualTo(1));
            Assert.That(hubResponse.rooms[0].roomId, Is.EqualTo(1));
        }

        [Test]
        public void ToHubResponseJson()
        {
            var hotelLegsResponseJson = "{\"results\":[{\"room\":1}]}";
            var expectedHubResponseJson = "{\"rooms\":[{\"roomId\":1}]}";

            var hotelLegResponse = HotelLegsResponse.FromJson(hotelLegsResponseJson);
            var hubResponseJson = new HotelLegsResponseAdapter(hotelLegResponse).ToJson();

            Assert.That(hubResponseJson, Is.EqualTo(expectedHubResponseJson));
        }
    }
}
