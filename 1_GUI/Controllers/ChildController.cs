using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_GUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService child;
        public ChildController(IChildService childService)
        {
            child = childService;
        }

        [HttpGet]
        public async Task<List<ChildModel>> Get()
        {
            return await child.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildModel> GetById(int id)
        {
            return await child.GetByIdAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await child.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<ChildModel> Put(int id, [FromBody] ChildModel childModel)
        {
            return await child.UpdateAsync(childModel);
        }
        [HttpPost]
        public async Task<ChildModel> Post([FromBody] ChildModel childModel)
        {
            int y = 0;
            return await child.AddAsync(childModel);
        }
    }
}
