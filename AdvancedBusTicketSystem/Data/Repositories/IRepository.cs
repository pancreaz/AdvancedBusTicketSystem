using AdvancedBusTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AdvancedBusTicketSystem.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        T GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        void SaveChanges();
    }
}
