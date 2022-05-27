using MedicalStatistician.DAL.Entities.Base;
using MedicalStatistician.DAL.Entities.DbContexts;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Repositories.EfCore
{
    /// <summary>
    /// Стандартная реализация crud репозитория <see cref="ICrudRepository{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <inheritdoc/>
    public class DefaultCrudRepository<T> : ICrudRepository<T> where T : Entity
    {
        protected MedicalStatisticianDbContext _context;
        protected DbSet<T> EntitySet => _context.Set<T>();
        public DefaultCrudRepository(MedicalStatisticianDbContext context)
        {
            _context = context;
        }
        public virtual int Create(T entity)
        {
            if (entity == null)
                return 0;
            var entry = EntitySet.Add(entity);
            if (entry == null)
                return 0;
            return _context.SaveChanges();
        }

        public virtual async Task<int> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            int result = 0;
            if (entity != null)
            {
                var entry = await EntitySet.AddAsync(entity, cancellationToken);
                if (entry != null)
                {
                    result = await _context.SaveChangesAsync(cancellationToken);
                }
            }
            return result;
        }

        public virtual int Delete(T entity)
        {
            if (entity == null)
                return 0;
            EntitySet.Remove(entity);
            return _context.SaveChanges();
        }

        public virtual async Task<int> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                return 0;
            EntitySet.Remove(entity);
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual IEnumerable<T> GetAll() => EntitySet.ToArray();

        public virtual async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
            => await EntitySet.ToArrayAsync(cancellationToken);

        public virtual T GetById(int id) => EntitySet.FirstOrDefault(entity => entity.Id == id);

        public virtual async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default)
            => await EntitySet.FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);

        public virtual int Update(T entity)
        {
            if (entity == null)
                return 0;
            EntitySet.Update(entity);
            return _context.SaveChanges();
        }

        public virtual async Task<int> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                return 0;
            EntitySet.Update(entity);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
