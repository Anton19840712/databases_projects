namespace Application.Models
{
    //Model consists of two another models...:
    public class CreateAuthorAndUserModel
    {
        public CreateAuthorModel AuthorModel { get; set; }

        public CreateUserModel UserModel { get; set; }
    }
}
