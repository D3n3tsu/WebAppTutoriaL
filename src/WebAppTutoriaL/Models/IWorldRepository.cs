using System.Collections.Generic;

namespace WebAppTutoriaL.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
        IEnumerable<Trip> GetAllTripsWithStops();
    }
}