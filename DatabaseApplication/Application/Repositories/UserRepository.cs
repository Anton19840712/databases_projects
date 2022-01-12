using Application.Entities;
using Application.Interfaces;
using Application.Repositories.Base;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class UserRepository : BaseRepository<User>, IRepositoryUser
    {
        public UserRepository(
            IMongoClient monGoClient,
            IClientSessionHandle clientSessionHandle) : base(monGoClient, clientSessionHandle, "user")
        {
        }

        //Trivial...:
        public async Task<User> GetUserAsync(string id)
        {
            var filter = Builders<User>
                .Filter
                .Eq(f => f.Id, id);

            return await Collection
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        //Trivial..:
        public async Task<IEnumerable<User>> GetUsersAsync() =>
            await Collection
                .AsQueryable()
                .ToListAsync();
    }
}
