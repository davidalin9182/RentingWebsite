using Microsoft.AspNetCore.Mvc;
using RentingWebsite.Data;
using RentingWebsite.Models;
namespace RentingWebsite.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RegisterController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Register> objAboutList = _db.Register;
            return View(objAboutList);
        }
    }
}