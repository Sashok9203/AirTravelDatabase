using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities
{
    public class Gender
    {
      //  [Key]
        public int Id { get; set; }

      //  [MaxLength(56)]
        public string Name { get; set; }

        public ICollection<Client> Clients { get; set; } = new HashSet<Client>();
    }
}
