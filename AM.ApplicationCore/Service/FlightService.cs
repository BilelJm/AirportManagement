using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class FlightService : IFlightService
    {
        ICollection<Flight> source;
        ShowLine showline;
        public FlightService(ICollection<Flight> source , ShowLine showline)
        {
             this.source = source;
             this.showline =  showline;

        }

        public void ShowFlights(string filterType, string filterValue)
        {
            try
            {
                showline($"^_^filterValue: { filterType} , filterValue :{ filterType}^_^");
                if (filterType == "Destination")
                {

                    foreach (Flight i in source)
                    {
                        if (i.Destination == filterValue)
                        {
                            showline(i.Destination);
                        }

                    }
                }
                else if (filterType == "FlightDate")
                {
                    DateTime filter_date = DateTime.Parse(filterValue);
                    foreach (Flight i in source)
                    {
                       
                        if (i.FlightDate == filter_date)
                        {
                            showline(i.FlightDate.ToString());
                        }

                    }
                }

                else if (filterType == "FlightId")
                {
                    Int32 filter_int = Int32.Parse(filterValue);
                    foreach (Flight i in source)
                    {
                       
                        if (i.FlightId == filter_int)
                        {
                            showline(i.FlightId.ToString());
                        }

                    }
                }
            } catch {
                throw new ArgumentException("Unkown filter");
            }
        }

        public List<Flight> Flights { get; set; }

        public IEnumerable<Tuple<int , float>> GetDurationsInMinutes() 
        { 
            return source.Select(e => new Tuple<int , float>(e.FlightId, e.EstimatedDuration * 60)); 
        }

        public List<Flight> GetFlightsSortedByDuration()
        {
            return source.OrderByDescending(e => e.EstimatedDuration).ToList();
        }

        public float GetDurationsAverage()
        {
            return source.Average(e => e.EstimatedDuration);
        }

        public IEnumerable<String> GetPassengerTypes( int idVol )
        {
            return source.Where(e => e.FlightId == idVol ).First().passengers.Select(e => e.PassngerType );
        }

        public IEnumerable<Tuple<int , float>> GetDurationsInMinutesLINQ()
        {
            return from p in source select new Tuple<int , float>(p.FlightId, p.EstimatedDuration * 60);
        }
    }
}
