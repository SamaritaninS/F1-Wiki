using F1.Models;
using System.Collections.Generic;

namespace F1.Interfaces
{
    public interface IGetNews
    {
        New GetObjectNew(int id);
        List<New> GetAllNews { get; }
    }
}
