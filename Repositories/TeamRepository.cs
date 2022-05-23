using F1.Data;
using F1.Interfaces;
using F1.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1.Repositories
{
    public class TeamRepository : IGetTeams
    {
        private readonly SiteContext _siteContext;
        public TeamRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }
        public Team GetObjectTeam(int id) => _siteContext.Team.FirstOrDefault(p => p.Id == id);
        public List<Team> GetAllTeams => _siteContext.Team.OrderByDescending(p => p.Points).ToList();

        
    }
}
