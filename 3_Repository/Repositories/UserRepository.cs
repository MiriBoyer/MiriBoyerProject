using Entity.Entities;
using _3_Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace _3_Repository.Repositories
{
    public class UserRepository : IUser
    {
        private readonly IDataSource dataSource;
        public UserRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public async Task<User> AddAsync(User model)
        {
            var u=dataSource.Users.Add(model);
            await dataSource.SaveChangesAsync();
            return u.Entity;
        }
        public async Task DeleteAsync(int id)
        {
            dataSource.Users.Remove(await GetByIdAsync(id));
            await dataSource.SaveChangesAsync();
        }

        public async Task< ICollection<User>> GetAllAsync()
        {
            return await dataSource.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int key)
        {
            return await dataSource.Users.FindAsync(key);
        }
        public async Task<User> UpdateAsync(User model)
        {
            var c = await GetByIdAsync(model.Id);
            c.FirstName = model.FirstName;
            c.LastName = model.LastName;
            c.IdNumber = model.IdNumber;
            c.DOB = model.DOB;
            c.gender = model.gender;
            c.HOM = model.HOM;
            await dataSource.SaveChangesAsync();
            return c;
        }
    }
}
