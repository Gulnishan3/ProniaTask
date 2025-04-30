using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Repositories.Abstractions
{
    public interface IRepository<T>where T : BaseEnitity
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}
