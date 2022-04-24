using Microsoft.AspNetCore.Mvc;
using RentingWebsite.Data;
using RentingWebsite.Models;
namespace RentingWebsite.Controllers
{
    public class CreditsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CreditsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Credits> objAboutList = _db.Credits;
            return View(objAboutList);
        }
    }
}