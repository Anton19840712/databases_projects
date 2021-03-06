using Application.Entities;
using Application.Interfaces.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRepositoryUser : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserAsync(string id);
    }
}
