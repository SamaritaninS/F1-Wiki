using F1.Models;
using System.Collections.Generic;

namespace F1.Interfaces
{
    public interface IGetTeams
    {
        Team GetObjectTeam(int id);
        List<Team> GetAllTeams { get; }

    }
}
