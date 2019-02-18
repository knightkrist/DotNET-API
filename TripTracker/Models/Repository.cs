using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.Models
{
    public class Repository
    {
        private List<Trip> myTrips = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Name = "Forie Islands",
                StartDate = new DateTime(2019, 3, 4),
                EndDate = new DateTime(2019, 4, 2)
            },
            new Trip
            {
                Id = 2,
                Name = "Paris",
                StartDate = new DateTime(2018, 3, 20),
                EndDate = new DateTime(2018, 4, 21)
            },
            new Trip
            {
                Id = 3,
                Name = "London",
                StartDate = new DateTime(2019, 6, 20),
                EndDate = new DateTime(2019, 7, 21)
            }
        };

        public List<Trip> Get()
        {
            return myTrips;
        }

        public Trip Get(int id)
        {
            return myTrips.First(i => i.Id == id);
        }

        public void Add(Trip newTrip)
        {
            myTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            myTrips.Remove(myTrips.First(i => i.Id == tripToUpdate.Id));

            Add(tripToUpdate);

        }

        public void Remove(int id)
        {
            myTrips.Remove(myTrips.First(j => j.Id == id));
        }
    }
}
