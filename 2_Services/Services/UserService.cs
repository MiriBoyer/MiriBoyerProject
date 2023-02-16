using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Interfaces;
using AutoMapper;
using Entity.Entities;

namespace _2_Services.Services
{
    public class UserService : IUserService
    {
        IUser user;
        IMapper mapper;
        public UserService(IUser user, IMapper mapper)
        {
            this.user = user;
            this.mapper = mapper;
        }
        public async Task<UserModel> AddAsync(UserModel model)
        {
            return mapper.Map<UserModel>(await user.AddAsync(mapper.Map<User>(model)));
        }

        public async Task DeleteAsync(int id)
        {
            await user.DeleteAsync(id);
        }

        public async Task<List<UserModel>> GetAllAsync()
        {
            return mapper.Map<List<UserModel>>(await user.GetAllAsync());
        }

        public async Task<UserModel> GetByIdAsync(int id)
        {
            return mapper.Map<UserModel>(await user.GetByIdAsync(id));
        }

        public async Task<UserModel> UpdateAsync(UserModel model)
        {
            return mapper.Map<UserModel>(await user.UpdateAsync(mapper.Map<User>(model)));
        }
    }
}
