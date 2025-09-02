

using AuthService.Domain.Entities;
using AuthService.Infrastructure.Entities;
using AutoMapper;

namespace AuthService.Infrastructure.Mappings;

public class UserMappingProfile: Profile
{
    public UserMappingProfile() 
    { 
        CreateMap<User, ApplicationUser>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Username));


        CreateMap<ApplicationUser, User>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.UserName));

    }
}
