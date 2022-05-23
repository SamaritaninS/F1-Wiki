using F1.Data;
using F1.Interfaces;
using F1.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1.Repositories
{
    public class RaceResultRepository : IGetRaceResults
    {
        private readonly SiteContext _siteContext;
        public RaceResultRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }
        public List<RaceResult> GetAllRaceResults => _siteContext.RaceResult.ToList();
    }
}
