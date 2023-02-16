using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task<  T> AddAsync(T model);
        Task<T> UpdateAsync(T model);
        Task DeleteAsync(int key);
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}
