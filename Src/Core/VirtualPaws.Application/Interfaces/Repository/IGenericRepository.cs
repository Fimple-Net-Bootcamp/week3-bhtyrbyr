using VirtualPaws.Domain.Common;

namespace VirtualPaws.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
        void Update(T entity);
        void Create(T entity);

    }
}
