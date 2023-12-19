using VirtualPaws.Domain.Common;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Interfaces.Repository.Entities
{
    public interface IGenericEntityRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Delete(T entity);
        void Update(T entity);
        void Create(T entity);

    }
}
