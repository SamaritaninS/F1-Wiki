using F1.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F1.Controllers
{
    public class StandingsController : Controller
    {

        private readonly IGetDrivers _getDrivers;
        private readonly IGetTeams _getTeams;
        private readonly IGetRaceResults _getRaceResults;

        public StandingsController(IGetDrivers getDrivers, IGetTeams getTeams, IGetRaceResults getRaceResults)
        {
            _getDrivers = getDrivers;
            _getTeams = getTeams;
            _getRaceResults = getRaceResults;
        }

        public ActionResult DriverStandings()
        {
            var drivers = _getDrivers.GetAllDrivers;
            return View(drivers);
        }

        public ActionResult TeamStandings()
        {
            var teams = _getTeams.GetAllTeams;
            return View(teams);
        }

        public ActionResult RaceResults()
        {
            var raceResults = _getRaceResults.GetAllRaceResults;
            return View(raceResults);
        }

    }
}
