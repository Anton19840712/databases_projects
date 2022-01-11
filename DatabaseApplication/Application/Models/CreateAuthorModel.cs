using System.Collections.Generic;

namespace Application.Models
{
    public class CreateAuthorModel
    {
        public string Name { get; set;  }

        public IEnumerable<BookModel> Books { get; set; }
    }
}
