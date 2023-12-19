using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Domain.Common;

namespace VirtualPaws.Application.Interfaces.Repository.Records
{
    public interface IGenericRecordRepository<T> where T : BaseRecordEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
    }
}
