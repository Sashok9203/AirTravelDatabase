﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities
{
    public class Country
    {
       // [Key]
        public int Id { get; set; }

      //  [MaxLength(56)]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; } = new HashSet<City>();
        public ICollection<Plane> AirPlanes { get; set; } = new HashSet<Plane>();
    }
}
