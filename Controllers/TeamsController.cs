using F1.Interfaces;
using F1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace F1.Controllers
{
    public class TeamsController : Controller
    {
        private readonly IGetTeams _getTeams;
        private readonly IGetDrivers _getDrivers;

        public TeamsController(IGetTeams getTeams, IGetDrivers getDrivers)
        {
            _getTeams = getTeams;
            _getDrivers = getDrivers;
        }

        public ActionResult Index()
        {
            var teams = _getTeams.GetAllTeams;

            return View(teams);
        }

        public IActionResult Details(int id)
        {
            if (id != 0)
            {
                Team team = _getTeams.GetObjectTeam(id);

                return View(team);
            }
            return NotFound();
        }


    }
}
