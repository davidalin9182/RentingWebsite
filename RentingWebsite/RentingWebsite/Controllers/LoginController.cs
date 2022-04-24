using Microsoft.AspNetCore.Mvc;
using RentingWebsite.Data;
using RentingWebsite.Models;
namespace RentingWebsite.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Login> objAboutList = _db.Login;
            return View(objAboutList);
        }
    }
}