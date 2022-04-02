using Data.DAL;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class EfRepositoryService<T> : IRepositoryService<T> where T: class, BaseEntity
    {

        protected readonly AppDbContext _context;

        public EfRepositoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<T> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task Create(T item)
        {
            throw new NotImplementedException();
        }

        public Task Create(List<T> items)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }



        public Task Update(int id, T item)
        {
            throw new NotImplementedException();
        }
    }
}
