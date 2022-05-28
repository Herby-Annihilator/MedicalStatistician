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
        public virtual T Create(T entity)
        {
            if (entity == null)
                return null;
            var entry = EntitySet.Add(entity);
            if (entry == null)
                return null;
            _context.SaveChanges();
            return entity;
        }

        public virtual async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var entry = await EntitySet.AddAsync(entity, cancellationToken).ConfigureAwait(false);
                if (entry != null)
                {
                    await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                }
            }
            return entity;
        }

        public virtual T Delete(T entity)
        {
            if (entity == null)
                return null;
            EntitySet.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual async Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                return null;
            EntitySet.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
            return entity;
        }

        public virtual IEnumerable<T> GetAll() => EntitySet.ToArray();

        public virtual async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
            => await EntitySet.ToArrayAsync(cancellationToken).ConfigureAwait(false);

        public virtual T GetById(int id) => EntitySet.FirstOrDefault(entity => entity.Id == id);

        public virtual async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default)
            => await EntitySet.FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken).ConfigureAwait(false);

        public virtual T Update(T entity)
        {
            if (entity == null)
                return null;
            EntitySet.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                return null;
            EntitySet.Update(entity);
            await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
            return entity;
        }

        public IEnumerable<T> Get(int skip, int count)
        {
            if (count <= 0)
                return Enumerable.Empty<T>();

            IQueryable<T> query = EntitySet switch
            {
                IOrderedQueryable<T> ordered_query => ordered_query,
                { } q => q.OrderBy(i => i.Id)
            };

            if (skip > 0)
                query = query.Skip(skip);
            return query.Take(count).ToArray();
        }

        public virtual async Task<IEnumerable<T>> GetAsync(int skip, int count, CancellationToken cancellationToken = default)
        {
            if (count <= 0)
                return Enumerable.Empty<T>();

            IQueryable<T> query = EntitySet switch
            {
                IOrderedQueryable<T> ordered_query => ordered_query,
                { } q => q.OrderBy(i => i.Id)
            };

            if (skip > 0)
                query = query.Skip(skip);
            return await query.Take(count).ToArrayAsync(cancellationToken).ConfigureAwait(false);
        }

        protected record DefaultPage(IEnumerable<T> Items, int TotalCount, int PageIndex, int PageSize) : IPage<T>
        {
            public int TotalPagesCount => (int)Math.Ceiling((double)TotalCount / PageSize);
        }

        public virtual IPage<T> GetPage(int pageIndex, int pageSize)
        {
            if (pageSize <= 0) return new DefaultPage(Enumerable.Empty<T>(), pageSize, pageIndex, pageSize);

            var query = EntitySet;
            var total_count = query.Count();
            if (total_count == 0)
                return new DefaultPage(Enumerable.Empty<T>(), 0, pageIndex, pageSize);

            if (query is not IOrderedQueryable<T>)
                query = (DbSet<T>)query.OrderBy(item => item.Id);

            if (pageIndex > 0)
                query = (DbSet<T>)query.Skip(pageIndex * pageSize);
            query = (DbSet<T>)query.Take(pageSize);

            var items = query.ToArray();

            return new DefaultPage(items, total_count, pageIndex, pageSize);
        }

        public virtual async Task<IPage<T>> GetPageAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default)
        {
            if (pageSize <= 0) return new DefaultPage(Enumerable.Empty<T>(), pageSize, pageIndex, pageSize);
            
            var query = EntitySet;
            var total_count = await query.CountAsync(cancellationToken).ConfigureAwait(false);
            if (total_count == 0)
                return new DefaultPage(Enumerable.Empty<T>(), 0, pageIndex, pageSize);

            if (query is not IOrderedQueryable<T>)
                query = (DbSet<T>)query.OrderBy(item => item.Id);

            if (pageIndex > 0)
                query = (DbSet<T>)query.Skip(pageIndex * pageSize);
            query = (DbSet<T>)query.Take(pageSize);

            var items = await query.ToArrayAsync(cancellationToken).ConfigureAwait(false);

            return new DefaultPage(items, total_count, pageIndex, pageSize);
        }
    }
}
