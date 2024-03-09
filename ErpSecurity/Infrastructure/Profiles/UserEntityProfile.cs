using AutoMapper;
using ErpSecurity.Domain.Entities;
using ErpSecurity.infrastructure.entities;

namespace ErpSecurity.Infrastructure.Profiles
{
    public class UserEntityProfile: Profile
    {
        public UserEntityProfile()
        {
            CreateMap<UserEntity, User>()
                .ForMember(dest => dest.FullName, src => src.MapFrom(x => x.Name + " " + x.LastName));
        }
    }
}