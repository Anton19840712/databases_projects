using System.Collections.Generic;

namespace Application.Models
{
    public class UpdateAuthorModel
    {
        public string Name { get; set; }

        public IEnumerable<BookModel> Books { get; set; }
    }
}
