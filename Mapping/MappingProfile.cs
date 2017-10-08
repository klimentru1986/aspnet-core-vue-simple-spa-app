using aspnet_vue.Controllers.Resources;
using aspnet_vue.Models;
using AutoMapper;

namespace aspnet_vue.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}