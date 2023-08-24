using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities
{
    public class Client
    {
     //   [Key]
        public int Id { get; set; }

        //[MaxLength(56)]
        public string Name { get; set; }

       // [MaxLength(56)]
        public string Surname { get; set; }

       // [MaxLength(256)]
        public string Email { get; set; }

        public string FullName => Name + " " + Surname;

       // [ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        //[ForeignKey("Gender")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }


        public ICollection<Flight> Flights { get; set; } = new HashSet<Flight>();

    }
}
