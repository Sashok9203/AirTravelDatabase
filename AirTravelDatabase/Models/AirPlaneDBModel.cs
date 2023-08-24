using AirTravelDatabase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Models
{
    internal class AirPlaneDBModel
    {
        private  AirPlaneDBContext dBContext;
        public AirPlaneDBModel()
        {
            dBContext = new();
        }

    }
}
