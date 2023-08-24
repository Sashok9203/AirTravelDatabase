using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities
{
    public class AirPlane
    {
       // [Key]
        public int Id { get; set; }

       // [MaxLength(56)]
        public string Model { get; set; }

     //   [ForeignKey("PlaneType")]
        public int PlaneTypeId { get; set; }
        public PlaneType PlaneType { get; set;}

     //   [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int PassengersCount { get; set; }

        public ICollection<Flight> Flights { get; set; } = new HashSet<Flight>();
    }
}
