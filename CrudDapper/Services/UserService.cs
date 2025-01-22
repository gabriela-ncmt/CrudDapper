using AutoMapper;
using CrudDapper.Dto;
using CrudDapper.Models;
using Dapper;
using System.Data.SqlClient;

namespace CrudDapper.Services
{
    public class UserService : IUserInterface
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public UserService(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<ResponseModel<List<UserListDto>>> GetUsers()
        {

            ResponseModel<List<UserListDto>> response = new ResponseModel<List<UserListDto>>();
            //creating connection...
            //...inside the parenthesis we're passing the connection
            //...the connection will be opened untill the end of the {}
            //...we won't need to manually close the connection
            //NEED TO INSTALL THE PACKAGE: DAPPER AND SYSTEM.Data.SQLClient
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var usersDataBase = await connection.QueryAsync<User>("SELECT * FROM Users");

                if(usersDataBase.Count() == 0)
                {
                    response.Message = "No users found!";
                    response.Status = false;
                    return response;
                }
                //transforming list type: UserModel to list type: UserListDTO using mapper
                //structure: _mapper.Map<to whom I want to transform> (who I'll transform);
                var mappedUser = _mapper.Map<List<UserListDto>>(usersDataBase);
                response.Datas = mappedUser;
                response.Status = true;
                response.Message = "Successfully located users";
            }
            return response;
         }
    }
}
