using System.Threading.Tasks;
using aspnet_vue.Controllers.Resources;
using aspnet_vue.Models;
using aspnet_vue.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_vue.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController
    {
        private readonly IMapper mapper;
        private readonly AspnetVueDbContext context;

        public VehiclesController(IMapper mapper, AspnetVueDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = this.mapper.Map<VehicleResource, Vehicle>(vehicleResource);

            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();

            var result = this.mapper.Map<Vehicle, VehicleResource>(vehicle);

            return new ObjectResult(result);
        }
    }
}