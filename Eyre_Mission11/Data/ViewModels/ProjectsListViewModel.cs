namespace Eyre_Mission11.Data.ViewModels
{
    public class ProjectsListViewModel
        {
            public IQueryable<Book> Books { get; set; }

            public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
        }
    
}
