using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _repository;
        
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<User> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
             return await _repository.SelectAsync();
        }
         

        public async Task<User> Post(User user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<User> Put(User user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
