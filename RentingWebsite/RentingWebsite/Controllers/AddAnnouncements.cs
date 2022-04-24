using Microsoft.AspNetCore.Mvc;
using RentingWebsite.Data;
using RentingWebsite.Models;
namespace RentingWebsite.Controllers
{
    public class AddAnnouncements : Controller
    {
        private readonly ApplicationDbContext _db;
        public AddAnnouncements(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<AddAnnouncements> objAboutList = _db.AddAnnouncements;
            return View(objAboutList);
        }
    }
}