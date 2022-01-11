namespace Application.Models
{
    public class BookModel
    {
        // The same style as in a constructor from business controller...: user => sign...:
        public BookModel(string name, int year) => (Name, Year) = (name, year);

        public string Name { get; set; }

        public int Year { get; set; }
    }
}
