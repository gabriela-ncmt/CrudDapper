using AutoMapper;
using CrudDapper.Dto;
using CrudDapper.Models;

namespace CrudDapper.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            //transforming type: User that is a MODEl to a type list of DTO
            CreateMap<User, UserListDto>();
        }
    }
}
