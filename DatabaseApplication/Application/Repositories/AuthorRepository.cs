using Application.Entities;
using Application.Interfaces;
using Application.Repositories.Base;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IRepositoryAuthor
    {
        public AuthorRepository(
            IMongoClient monGoClient,
            IClientSessionHandle clientSessionHandle) : base(monGoClient, clientSessionHandle, "author")
        {
        }

        public async Task<Author> GetAuthorByIdAsync(string id)
        {
            // Here you can see, that you do not use (string) object, but just id
            var filter = Builders<Author>
                .Filter
                .Eq(s => s.Id, id);

            return await Collection.Find(filter).FirstOrDefaultAsync();
        }

        // Here is familiar syntax to me... I mean: Collection.AsQueryable().ToListAsync()...:
        public async Task<IEnumerable<Author>> GetAuthorsAsync() => await Collection.AsQueryable().ToListAsync();

        public async Task<IEnumerable<Book>> GetBooksAsync(string authorId)
        {
            //we create here author as a filter...:

            var filter = Builders<Author>
                .Filter
                .Eq(s => s.Id, authorId);


            return await Collection
                .Find(filter)//we take this author...:

                .Project(p => p.Books)//Pay attention, that here you can see something similar to mapping...:
                //and project his books to the inside collection...:

                .FirstOrDefaultAsync();
        }

        //Here the code is also trivial...:
        public async Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name)
        {
            var filter = Builders<Author>
                .Filter
                .Eq(s => s.Name, name);

            return await Collection
                .Find(filter)
                .ToListAsync();
        }
    }
}
