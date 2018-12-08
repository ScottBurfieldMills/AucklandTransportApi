using AucklandTransportApi.Core.Requests;
using Xunit;

namespace AucklandTransportApi.Core.Tests.Requests
{
    public class VehicleLocationRequestTest
    {
        [Fact]
        public void VehicleAndTripIdIncludedIfIdsAreValid()
        {
            // Arrange
            var expected = "https://api.at.govt.nz/v2/public/realtime/vehiclelocations?tripid=144&vehicleid=29010";

            var request = new VehicleLocationRequest
            {
                TripId = 144,
                VehicleId = 29010
            };

            // Act
            var actual = request.GetEndpointUrl();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void VehicleIncludedIfValid()
        {
            // Arrange
            var expected = "https://api.at.govt.nz/v2/public/realtime/vehiclelocations?vehicleid=29010";

            var request = new VehicleLocationRequest
            {
                VehicleId = 29010
            };

            // Act
            var actual = request.GetEndpointUrl();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TripIncludedIfValid()
        {
            // Arrange
            var expected = "https://api.at.govt.nz/v2/public/realtime/vehiclelocations?tripid=144";

            var request = new VehicleLocationRequest
            {
                TripId = 144
            };

            // Act
            var actual = request.GetEndpointUrl();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
