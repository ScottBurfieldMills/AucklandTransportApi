using AucklandTransportApi.Requests;
using AucklandTransportApi.Responses;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AucklandTransportApi
{
    public class AucklandTransport
    {
        private readonly string _apiKey;
        private readonly static string _apiKeyHeaderName = "Ocp-Apim-Subscription-Key";
        private static readonly HttpClient _httpClient = new HttpClient();

        public AucklandTransport(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<VehicleLocationResponse> GetVehicleLocationsAsync(int? tripId = null, int? vehicleId = null)
        {
            var vehicleLocationRequest = new VehicleLocationRequest
            {
                ApiKey = _apiKey,
                TripId = tripId,
                VehicleId = vehicleId
            };

            var endpointUrl = vehicleLocationRequest.GetEndpointUrl();

            var httpRequestMessage = new HttpRequestMessage
            {
                RequestUri = new Uri(endpointUrl),
            };

            httpRequestMessage.Headers.Add(_apiKeyHeaderName, _apiKey);

            var response = await _httpClient.SendAsync(httpRequestMessage);
            response.EnsureSuccessStatusCode();

            var stringResult = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<VehicleLocationResponse>(stringResult);

            return result;
        }
    }
}
