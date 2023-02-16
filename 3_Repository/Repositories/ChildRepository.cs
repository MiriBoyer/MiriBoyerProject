using Entity.Entities;
using _3_Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _3_Repository.Repositories
{
    public class ChildRepository : IChild
    {
        private readonly IDataSource dataSource;
        public ChildRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public async Task<Child> AddAsync(Child model)
        {
            //int n = 0;
            var u = dataSource.Children.Add(model);
            await dataSource.SaveChangesAsync();
            return u.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            dataSource.Children.Remove(await GetByIdAsync(id));
            await dataSource.SaveChangesAsync();
        }

        public async Task<ICollection<Child>> GetAllAsync()
        {
           // Child c=new Child();
            //c.Id = 1;
            //c.Name = "test";
            //c.DOB=DateTime.Now;
            //Child c2 = new Child();
            //c2.Id = 1;
            //c2.Name = "test";
            //c2.DOB = DateTime.Now;
            //List<Child> c3 = new List<Child>();
            //c3.Add(c);
            //c3.Add(c2);
            //return c3;

            return await dataSource.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int key)
        {
            return await dataSource.Children.FindAsync(key);
        }
        public async Task<Child> UpdateAsync(Child model)
        {
            var c = await GetByIdAsync(model.Id);
            c.Name = model.Name;
            c.DOB = model.DOB;
            c.IdNumber = model.IdNumber;
            await dataSource.SaveChangesAsync();
            return c;
        }
    }
}
