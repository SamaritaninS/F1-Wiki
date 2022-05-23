using F1.Interfaces;
using F1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F1.Controllers
{
    public class ScheduleController : Controller
    {

        private readonly IGetRaces _getRaces;

        public ScheduleController(IGetRaces getRaces)
        {
            _getRaces = getRaces;
        }

        public ActionResult Index()
        {
            var races = _getRaces.GetAllRaces;
            return View(races);
        }

        public IActionResult Details(int id)
        {
            if (id != 0)
            {
                Race race = _getRaces.GetObjectRace(id);

                return View(race);
            }


            return NotFound();
        }

    }
}
