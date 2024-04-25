using AutoMapper;
using Commerce.Models.Email;
using Commerce.Models.Identity;

namespace Commerce.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ApplicationUser, EmailConfirmationMessage>().ReverseMap();

        }
    }
}
