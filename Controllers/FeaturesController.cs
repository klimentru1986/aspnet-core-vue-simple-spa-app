using System.Collections.Generic;
using System.Threading.Tasks;
using aspnet_vue.Controllers.Resources;
using aspnet_vue.Models;
using aspnet_vue.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspnet_vue.Controllers
{
    public class FeaturesController
    {
        private readonly IMapper maper;
        private readonly AspnetVueDbContext context;

        public FeaturesController(AspnetVueDbContext context, IMapper maper)
        {
            this.context = context;
            this.maper = maper;
        }

        [HttpGet("api/features")]
        public async Task<IEnumerable<FeatureResource>> getFeatures()
        {
            var features = await this.context.Features.ToListAsync();

            return this.maper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}