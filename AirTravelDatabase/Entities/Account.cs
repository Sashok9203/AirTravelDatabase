using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities
{
    public  class Account
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Login { get; set; }

        [MaxLength(56)]
        public string Password { get; set; }

    }
}
