using Microsoft.EntityFrameworkCore;
using RAT.Domain.Models;
using RAT.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RAT.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {

        private readonly RatDbContextFactory _contextFactory;

        public GenericDataService(RatDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
           
            using(RatDbContext context = _contextFactory.CreateDbContext())
            {
                var createdEntity = await context.Set<T>().AddAsync(entity);
                await context.Set<T>().AddAsync(entity);

                return createdEntity.Entity;
              }
        }

        public async Task<bool> Delete(int id)
        {
            using (RatDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (RatDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (RatDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
                
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (RatDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }
    }
}
