using System.Linq;
using aspnet_vue.Controllers.Resources;
using aspnet_vue.Models;
using AutoMapper;

namespace aspnet_vue.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            //Domain to API
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<Vehicle, VehicleResource>()
            .ForMember(vr => vr.Contact, opt => opt.MapFrom(v =>
            new ContactResource
            {
                Name = v.ContactName,
                Email = v.ContactEmail,
                Phone = v.ContactPhone
            }))
            .ForMember(vr => vr.Features, opt => opt.MapFrom(v =>
                v.Features.Select(vf => vf.FeatureId)
            ));

            //API to Domain
            CreateMap<VehicleResource, Vehicle>()
            .ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name))
            .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
            .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
            .ForMember(v => v.Features, opt => opt.MapFrom(vr => vr.Features.Select(id => new VehicleFeature
            {
                FeatureId = id
            })));
        }
    }
}