using AirTravelDatabase.Data;
using AirTravelDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AirTravelDatabase.Models
{
    public class AirTraveDBModel : INotifyPropertyChanged
    {
        private AirTraveDBContext dBContext;
        private DateTime? sDate;
        private City? city;
        private Flight[]? flight;

        private void find()
        {
            flight = dBContext.Flights.Where(x => x.ArrivalCityId == From.Id && x.Arrival.Date == SelectedDate.Value.Date)
                                    .Include(x => x.Plane).ThenInclude(x => x.PlaneType)
                                    .Include(x => x.Plane).ThenInclude(x => x.Country)
                                    .Include(x => x.ArrivalCity).Include(x => x.DepartureCity).ToArray();
            //OnPropertyChanged("Flights");
            city = null;
            sDate = null;
        }

        public AirTraveDBModel()
        {
            dBContext = new();
            Find = new((o) => find(), (o) => sDate != null && city != null);
        }


        public DateTime? SelectedDate { get; set; }
     
        public City? From { get; set; }

        public RelayCommand Find { get; set; }

        public IEnumerable<Flight>? Flights => flight;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
