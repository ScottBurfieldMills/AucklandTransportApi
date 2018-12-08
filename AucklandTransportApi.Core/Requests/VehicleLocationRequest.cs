namespace AucklandTransportApi.Core.Requests
{
    public class VehicleLocationRequest
    {
        public string ApiEndpoint = "https://api.at.govt.nz/v2/public/realtime/vehiclelocations";

        public int? TripId { get; set; }
        public int? VehicleId { get; set; }

        public string ApiKey { get; set; }

        public string GetEndpointUrl()
        {
            var endpointUrl = ApiEndpoint;
            var firstCondition = true;

            void AddCondition(string condition)
            {
                endpointUrl += firstCondition 
                    ? $"?{condition}"
                    : $"&{condition}";
                
                firstCondition = false;
            }

            if (TripId.HasValue)
            {
                AddCondition($"tripid={TripId.Value}");
            }

            if (VehicleId.HasValue)
            {
                AddCondition($"vehicleid={VehicleId.Value}");
            }

            AddCondition($"apikey={ApiKey}");
            
            return endpointUrl;
        }
    }
}
