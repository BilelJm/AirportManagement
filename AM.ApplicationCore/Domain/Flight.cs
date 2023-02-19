using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public IList<Passenger> passengers { get; set; }
        public Plane plane { get; set; }
        public string Departure { get; set; }
        public  string  Destination { get; set; }
        public DateTime EffictiveArrival { get; set; }
        public float EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }


        public override string ToString()
        {
            return  "Flight : FlightId: " + FlightId + 
                    " , Destination:  " + Destination + 
                    " , FlightDate: " + FlightDate;
        }
    }
}
