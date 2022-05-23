using F1.Models;
using System.Collections.Generic;

namespace F1.Interfaces
{
    public interface IGetRaceResults
    {
        List<RaceResult> GetAllRaceResults { get; }
    }
}
