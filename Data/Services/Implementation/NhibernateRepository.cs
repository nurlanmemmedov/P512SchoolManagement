using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class NhibernateRepository<T> : IRepositoryService<T> where T : class, BaseEntity
    {
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

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, T item)
        {
            throw new NotImplementedException();
        }
    }
}
