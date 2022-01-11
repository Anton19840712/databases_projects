using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Entities;
using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IRepositoryUser _repositoryUser;
        private readonly IRepositoryAuthor _repositoryAuthor;

        private readonly IClientSessionHandle _clientSessionHandle;

        //Used => sign for constructor. Nice.
        public BusinessController(IRepositoryUser repositoryUser, IRepositoryAuthor repositoryAuthor, IClientSessionHandle clientSessionHandle) =>
            (_repositoryUser, _repositoryAuthor, _clientSessionHandle) = (repositoryUser, repositoryAuthor, clientSessionHandle);

        [HttpPost]
        [Route("user")]
        // Used [FromBody] attribute.
        public async Task<IActionResult> InsertUser([FromBody] CreateUserModel userModel)
        {
            //Used such aspect as StartTransaction() - so, this give more control to the process of using current endpoint.
            _clientSessionHandle.StartTransaction();

            //All code parts of endpoints dealing with database are wrapped into try-catch pattern.
            try
            {
                var user = new User(userModel.Name, userModel.Nin);
                await _repositoryUser.InsertAsync(user);

                //If you start a transaction, you should pass the handle when you do some operation
                await _clientSessionHandle.CommitTransactionAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                //If you start a transaction, you should pass the handle when you do some operation
                await _clientSessionHandle.AbortTransactionAsync();

                return BadRequest(ex);
            }

            //So, the PECULIARITY of this code is using of more controlled process of transactions.
        }


        //NOTES:
        //----------------------------

        //CreateAuthorAndUserModel consists of two fields of such model types as: 

        //1) CreateAuthorModel: Name + IEnumerable<BookModel> => BookModel: => Name + Year plus constructor with => sign


        //2) CreateUserModel => Name + Nin

        [HttpPost]
        [Route("authorAndUser")]
        public async Task<IActionResult> InsertAuthorAndUser([FromBody] CreateAuthorAndUserModel authorAndUserModel)
        {
            //Using start transaction again...
            //_clientSessionHandle - is an interface, thar enables to commit transactions...:

            _clientSessionHandle.StartTransaction();

            //Using of try-catch pattern again...:
            try
            {
                // We create here Author...:
                var author = new Author(

                    authorAndUserModel.AuthorModel.Name, 

                    new List<Book>(authorAndUserModel.AuthorModel.Books.Select(s => new Book(s.Name, s.Year))));
                

                // We create here User... we get it fom the incoming model from body...:
                var user = new User(authorAndUserModel.UserModel.Name, authorAndUserModel.UserModel.Nin);


                //Here I can see trivial things... as InsertAsync...:

                await _repositoryAuthor.InsertAsync(author);//this command creates new instance of AUTHOR in the database...:

                await _repositoryUser.InsertAsync(user);//this command creates new instance of USER in the database...:


                //Commit, like AMEN
                await _clientSessionHandle.CommitTransactionAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                //If something went wrong - we abort our transaction...:
                await _clientSessionHandle.AbortTransactionAsync();

                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("author/{id}")]
        public async Task<IActionResult> DeleteAuthorAsync([FromRoute] string id)
        {
            _clientSessionHandle.StartTransaction();

            try
            {
                await _repositoryAuthor.DeleteAsync(id);//the same trivial logic...:

                await _clientSessionHandle.CommitTransactionAsync();
                
                return Ok();
            }
            catch (Exception ex)
            {
                await _clientSessionHandle.AbortTransactionAsync();

                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("author/{id}")]
        public async Task<IActionResult> DeleteAuthorAsync([FromRoute] string id, [FromBody] UpdateAuthorModel authorModel)
        {
            _clientSessionHandle.StartTransaction();

            try
            {
                var author = new Author(authorModel.Name, new List<Book>(authorModel.Books.Select(s => new Book(s.Name, s.Year))));
                author.SetId(id);

                await _repositoryAuthor.UpdateAsync(author); //Nothing trivial again with update...:

                await _clientSessionHandle.CommitTransactionAsync();

                return Ok();
            }
            catch (Exception ex)
            {

                await _clientSessionHandle.AbortTransactionAsync();

                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("author/books/{id}")]
        public async Task<IActionResult> GetAuthorsBookAsync([FromRoute] string id)
        {
            try
            {
                var books = await _repositoryAuthor.GetBooksAsync(id);
                var booksModel = new List<BookModel>(books.Select(s => new BookModel(s.Name, s.Year)));
                return Ok(booksModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}