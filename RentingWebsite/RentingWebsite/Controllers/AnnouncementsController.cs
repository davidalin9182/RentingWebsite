using Microsoft.AspNetCore.Mvc;
using RentingWebsite.Data;
using RentingWebsite.Models;
namespace RentingWebsite.Controllers
{
    public class AnnouncementsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AnnouncementsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Announcements> objAboutList = _db.Announcements;
            return View(objAboutList);
        }
    }
}