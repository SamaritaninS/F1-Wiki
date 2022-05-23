using F1.Interfaces;
using F1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F1.Controllers
{
    public class DriversController : Controller
    {
        private readonly IGetDrivers _getDrivers;

        public DriversController(IGetDrivers getDrivers)
        {
            _getDrivers = getDrivers;
        }

        public ActionResult Index()
        {
            var drivers = _getDrivers.GetAllDrivers;
            return View(drivers);
        }

        public IActionResult Details(int id)
        {
            if (id != 0)
            {
                Driver driver = _getDrivers.GetObjectDriver(id);

                return View(driver);
            }


            return NotFound();
        }


    }
}
