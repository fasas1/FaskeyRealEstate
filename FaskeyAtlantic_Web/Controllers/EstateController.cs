using FaskeyAtlantic.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace FaskeyAtlantic_Web.Controllers
{
	public class EstateController : Controller
	{
		private readonly ApplicationDbContext _db;
        public EstateController(ApplicationDbContext db)
        {
			_db = db;
        }
        public IActionResult Index()
		{
			var estates = _db.Estates.ToList();
			return View(estates);
		}
		public IActionResult CreateEstate()
		{
			return View();
		}
	}
}
