using aspnet_vue.Controllers.Resources;
using aspnet_vue.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_vue.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController
    {
        private readonly IMapper mapper;

        public VehiclesController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = this.mapper.Map<VehicleResource, Vehicle>(vehicleResource);

            return new ObjectResult(vehicle);
        }
    }
}