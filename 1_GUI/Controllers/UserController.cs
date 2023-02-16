using _2_Services.Interfaces;
using _2_Services.Models;
using AutoMapper;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_GUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper mapper;
        //
        private readonly IUserService user;
        public UserController(IMapper mapper, IUserService user)
        {
            this.mapper = mapper;
            this.user = user;
        }

        [HttpGet]
        public async Task<List<UserModel>> Get()
        {
            return await user.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserModel> GetById(int id)
        {
            return await user.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<UserModel> Post([FromBody] UserModel model)
        {
            int n = 0;
            return await user.AddAsync(model);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await user.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<UserModel> Put(int id, [FromBody] UserModel model)
        {
            return await user.UpdateAsync(model);
        }
    }
}
