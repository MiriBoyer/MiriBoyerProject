using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Interfaces;
using _3_Repository.Repositories;
using AutoMapper;
using Entity.Entities;

namespace _2_Services.Services
{
    public class ChildService : IChildService
    {
        private readonly IChild child;
        private readonly IMapper mapper;
        public ChildService(IChild child, IMapper mapper)
        {
            this.child = child;
            this.mapper = mapper;
        }

        public async Task<ChildModel> AddAsync(ChildModel model)
        {
            int n = 9;
            return mapper.Map<ChildModel>(await child.AddAsync(mapper.Map<Child>(model)));
        }

        public async Task DeleteAsync(int id)
        {
            await child.DeleteAsync(id);
        }

        public async Task<List<ChildModel>> GetAllAsync()
        {
            return mapper.Map<List<ChildModel>>(await child.GetAllAsync());
        }

        public async Task<ChildModel> GetByIdAsync(int id)
        {
            return mapper.Map<ChildModel>(await child.GetByIdAsync(id));
        }

        public async Task<ChildModel> UpdateAsync(ChildModel model)
        {
            return mapper.Map<ChildModel>(await child.UpdateAsync(mapper.Map<Child>(model)));
        }
    }
}
