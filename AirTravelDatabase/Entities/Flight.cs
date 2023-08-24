using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities
{
    public class Flight
    {
        // [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime Arrival { get; set; }

        public DateTime Departure { get; set; }

        // [ForeignKey("AirPlane")]
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }

        public int? ArrivalCityId { get; set; }
        public City? ArrivalCity { get; set; }

        public int?  DepartureCityId { get; set; }
        public City? DepartureCity { get; set; }

        public ICollection<Client> Clients { get; set; } = new HashSet<Client>();

    }
}
