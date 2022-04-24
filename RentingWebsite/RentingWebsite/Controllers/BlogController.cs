using Microsoft.AspNetCore.Mvc;
using RentingWebsite.Data;
using RentingWebsite.Models;
namespace RentingWebsite.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BlogController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Blog> objAboutList = _db.Blog;
            return View(objAboutList);
        }
    }
}