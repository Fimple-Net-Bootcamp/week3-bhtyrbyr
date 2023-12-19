using VirtualPaws.Application.Interfaces.Repository.Records;
using VirtualPaws.Domain.Common;
using VirtualPaws.Persistence.Context;

namespace VirtualPaws.Persistence.Repositories.Records
{
    public class GenericRecordRepository<T> : IGenericRecordRepository<T> where T : BaseRecordEntity
    {
        private readonly AppDbContext _dbContext;

        public GenericRecordRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }
    }
}
