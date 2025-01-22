using CrudDapper.Dto;
using CrudDapper.Models;

namespace CrudDapper.Services
{
    public interface IUserInterface
    {
        Task<ResponseModel<List<UserListDto>>> GetUsers();
        Task<ResponseModel<UserListDto>> GetUserById(int userId);

        Task<ResponseModel<List<UserListDto>>> CreateUser (CreateUserDto createUserDto);

        Task<ResponseModel<List<UserListDto>>> EditUser(EditUserDto editUserDto);

        Task<ResponseModel<List<UserListDto>>> DeleteUser (int userId);
    }
}
