using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        public BaseRepository(MyContext context){
            
        }
        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
