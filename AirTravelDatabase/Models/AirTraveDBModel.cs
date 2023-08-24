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
    public class AirTraveDBModel : INotifyPropertyChanged,IDisposable
    {
        private AirTraveDBContext dBContext;

        private City? city;

        private Flight[]? flight;

        private bool disposedValue;

        private void find()
        {
            flight = dBContext.Flights.Where(x => x.ArrivalCityId == From.Id && x.Arrival.Date == SelectedDate.Value.Date)
                                    .Include(x => x.Plane).ThenInclude(x => x.PlaneType)
                                    .Include(x => x.Plane).ThenInclude(x => x.Country)
                                    .Include(x => x.ArrivalCity).Include(x => x.DepartureCity).ToArray();
            OnPropertyChanged("Flights");
            From = null;
        }

        public AirTraveDBModel()
        {
            dBContext = new();
            Find = new((o) => find(), (o) => SelectedDate != null && city != null);
        }

        public DateTime? SelectedDate { get; set; }
       
     
        public City? From 
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand Find { get; set; }

        public IEnumerable<Flight>? Flights => flight;

        public IEnumerable<City>?   Cities  => dBContext.Cities.ToArray();

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)  {dBContext.Dispose();}
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
