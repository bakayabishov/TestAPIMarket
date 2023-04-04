using AutoMapper;
using TestAPIMarket.Data.Entities;

namespace TestAPIMarket.Business.Models.Mappings;

public class UserMappingProfile : Profile {
    public UserMappingProfile()
    {
        CreateMap<UserDto, User>();
    }

}