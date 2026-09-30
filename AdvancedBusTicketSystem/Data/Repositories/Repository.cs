using AdvancedBusTicketSystem.Data.Persistence;
using AdvancedBusTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedBusTicketSystem.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly List<T> _entities;
        private readonly Action _onSave;

        public Repository(List<T> entities, Action onSave)
        {
            _entities = entities ?? new List<T>();
            _onSave = onSave;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Where(e => e.IsActive).ToList();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _entities.Where(e => e.IsActive).Where(predicate).ToList();
        }

        public T GetById(Guid id)
        {
            return _entities.FirstOrDefault(e => e.Id == id && e.IsActive);
        }

        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _entities.Add(entity);
            SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            int index = _entities.FindIndex(e => e.Id == entity.Id);
            if (index >= 0)
            {
                _entities[index] = entity;
                SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            T entity = GetById(id);
            if (entity != null)
            {
                entity.IsActive = false; // Soft delete
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _onSave?.Invoke();
        }
    }
}
