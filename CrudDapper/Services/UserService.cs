using CrudDapper.Dto;
using CrudDapper.Models;

namespace CrudDapper.Services
{
    public class UserService : IUserInterface
    {
        private readonly IConfiguration _configuration;
        public UserService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<ResponseModel<List<UserListDto>>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
