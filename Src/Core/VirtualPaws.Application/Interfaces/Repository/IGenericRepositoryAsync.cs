using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Domain.Common;

namespace VirtualPaws.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> DeleteAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<T> CreateAsync(T entity);

    }
}
