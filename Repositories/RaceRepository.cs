using F1.Data;
using F1.Interfaces;
using F1.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1.Repositories
{
    public class RaceRepository : IGetRaces
    {
        private readonly SiteContext _siteContext;
        public RaceRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }
        public Race GetObjectRace(int id) => _siteContext.Race.FirstOrDefault(p => p.Id == id);
        public List<Race> GetAllRaces => _siteContext.Race.OrderBy(p => p.Round).ToList();
    }
}
