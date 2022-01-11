namespace Application.Models
{
    public class BookModel
    {
        public BookModel(string name, int year) => (Name, Year) = (name, year);

        public string Name { get; set; }

        public int Year { get; set; }
    }
}
