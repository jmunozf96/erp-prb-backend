using AutoMapper;
using ErpSecurity.Domain.Models;
using ErpSecurity.Presentation.Dtos;

namespace ErpSecurity.Presentation.Profiles
{
    public class AuthenticationProfile : Profile
    {
        public AuthenticationProfile()
        {
            CreateMap<SignInDTO, InputSignIn>();
            CreateMap<OutputSignIn, ResponseAuthDTO>();
        }
    }
}
