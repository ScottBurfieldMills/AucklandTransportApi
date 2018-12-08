using System.Threading.Tasks;
using System.Linq;

namespace AucklandTransportApi.WinConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var aucklandTransport = new AucklandTransport("API_KEY");

            var locations = await aucklandTransport.GetVehicleLocationsAsync();

            var vehicles = locations.Response.Entities.Select(x => x.Vehicle)
                .ToList();
        }
    }
}
