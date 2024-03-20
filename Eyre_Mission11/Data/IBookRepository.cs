namespace Eyre_Mission11.Data
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }

    }
}

