using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Eyre_Mission11.Data;
using Eyre_Mission11.Data.ViewModels;


namespace Eyre_Mission11.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {

            int pageSize = 10;
            var Blah = new ProjectsListViewModel
            {
                Books = _repo.Books
               .OrderBy(x => x.Title)
               .Skip((pageNum - 1) * pageSize)
               .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(Blah);

        }


    }
}
