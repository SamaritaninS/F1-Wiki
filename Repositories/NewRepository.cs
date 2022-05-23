using F1.Data;
using F1.Interfaces;
using F1.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1.Repositories
{
    public class NewRepository : IGetNews
    {
        private readonly SiteContext _siteContext;
        public NewRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }
        public New GetObjectNew(int id) => _siteContext.New.FirstOrDefault(p => p.Id == id);
        public List<New> GetAllNews => _siteContext.New.OrderBy(p => p.Id).ToList();
    }
}
