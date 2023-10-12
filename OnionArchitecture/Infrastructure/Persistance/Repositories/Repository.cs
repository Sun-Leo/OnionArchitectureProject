using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OnionContext _onionContext;

        public Repository(OnionContext onionContext)
        {
            _onionContext = onionContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            _onionContext.Add(entity);
            await _onionContext.SaveChangesAsync();
            return entity;
            
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _onionContext.Remove(entity);
            await _onionContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _onionContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _onionContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _onionContext.Update(entity);
            await _onionContext.SaveChangesAsync();
            return entity;
        }
    }
}
