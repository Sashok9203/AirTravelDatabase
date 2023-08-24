using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities
{
    public class City
    {
        // [Key]
        public  int Id { get; set; }

        // [MaxLength(56)]
        public  string Name { get; set; }

        // [ForeignKey("Country")]
        public  int CountryId { get; set; }
        public  Country Country {get;set;}

        public ICollection<Flight> ArivalFlights { get; set; } = new HashSet<Flight>();
        public ICollection<Flight> DepartureFlights { get; set; } = new HashSet<Flight>();

    }
}
