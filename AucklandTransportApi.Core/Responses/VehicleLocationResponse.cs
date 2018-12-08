using AucklandTransportApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AucklandTransportApi.Core.Responses
{
    public class VehicleLocationResponse
    {
        public string Status { get; set; }
        public Response Response { get; set; }
        public object Error { get; set; }
    }
}
