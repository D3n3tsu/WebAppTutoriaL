using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTutoriaL.Models
{
    public class WorldContextSeedData
    {
        private WorldContext _context;

        public WorldContextSeedData(WorldContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if (!_context.Trips.Any())
            {
                //Add new data
                var usTrip = new Trip()
                {
                    Name = "US Trip",
                    Created = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>
                    {
                        new Stop {Name ="Atlanta, GA",Arrival = new DateTime(2014,6,4),Latitude = 33.748995,Longitude=-84.387982,Order=0 },
                        new Stop {Name="New York, NY",Arrival= new DateTime(2014,6,6), Latitude = 40.712784, Longitude = -74.005941, Order =1 }
                    }
                };

                _context.Trips.Add(usTrip);
                _context.Stops.AddRange(usTrip.Stops);

                var worldTrip = new Trip()
                {
                    Name = "World Trip",
                    Created = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>
                    {
                        new Stop {Name ="Boston, MA",Arrival = new DateTime(2014,10,4),Latitude = 42.360082,Longitude=-71.058880,Order=0 },
                        new Stop {Name="Chicago, IL",Arrival= new DateTime(2014,10,7), Latitude = 41.878114, Longitude = -87.629798, Order =1 }
                    }
                };

                _context.Trips.Add(worldTrip);
                _context.Stops.AddRange(worldTrip.Stops);

                _context.SaveChanges();
            }
        }
    }
}
