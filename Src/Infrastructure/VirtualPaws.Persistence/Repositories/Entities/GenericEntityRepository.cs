using Microsoft.EntityFrameworkCore;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Common;
using VirtualPaws.Domain.Entities;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Entities
{
    public class GenericEntityRepository<T> : IGenericEntityRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;
        public GenericEntityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().OrderBy(pet => pet.Id).ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
