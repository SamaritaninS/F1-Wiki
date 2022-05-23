using F1.Models;
using System.Collections.Generic;

namespace F1.Interfaces
{
    public interface IGetRaces
    {
        Race GetObjectRace(int id);
        List<Race> GetAllRaces { get; }
    }
}
