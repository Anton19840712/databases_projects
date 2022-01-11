using Application.Entities;
using Application.Interfaces.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    //Nothing complex here...:
    public interface IRepositoryAuthor : IRepositoryBase<Author>
    {
        Task<IEnumerable<Book>> GetBooksAsync(string id);

        Task<IEnumerable<Author>> GetAuthorsAsync();

        Task<Author> GetAuthorByIdAsync(string authorId);

        Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name);
    }
}
