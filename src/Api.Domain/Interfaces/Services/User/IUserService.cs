using System;
using System.Collections.Generic;
using System.Threading.Tasks;
 
namespace Api.Domain.Interfaces.Services.User {
    public interface IUserService {
        Task<Api.Domain.Entities.User> Get (Guid id);
        Task<IEnumerable<Api.Domain.Entities.User>> GetAll ();
        Task<Api.Domain.Entities.User> Post (Api.Domain.Entities.User user);
        Task<Api.Domain.Entities.User> Put (Api.Domain.Entities.User user);
        Task<bool> Delete (Guid id);
    }
}
