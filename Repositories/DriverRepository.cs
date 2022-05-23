using F1.Data;
using F1.Interfaces;
using F1.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1.Repositories
{
    public class DriverRepository : IGetDrivers
    {
        private readonly SiteContext _siteContext;
        public DriverRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }
        public Driver GetObjectDriver(int id) => _siteContext.Driver.FirstOrDefault(p => p.Id == id);
        public List<Driver> GetAllDrivers => _siteContext.Driver.OrderByDescending(p => p.Points).ToList();
    }
}
