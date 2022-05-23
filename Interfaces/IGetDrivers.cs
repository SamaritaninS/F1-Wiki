using F1.Models;
using System.Collections.Generic;

namespace F1.Interfaces
{
    public interface IGetDrivers
    {
        Driver GetObjectDriver(int id);
        List<Driver> GetAllDrivers { get; }

    }
}
