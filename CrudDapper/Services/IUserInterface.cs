using CrudDapper.Dto;
using CrudDapper.Models;

namespace CrudDapper.Services
{
    public interface IUserInterface
    {
        Task<ResponseModel<List<UserListDto>>> GetUsers();
        Task<ResponseModel<UserListDto>> GetUserById(int userId);

        Task<ResponseModel<List<UserListDto>>> CreateUser (CreateUserDto createUserDto);
    }
}
