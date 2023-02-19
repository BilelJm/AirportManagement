using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class InMemorySource
    {

        public static Plane Boeing1 { get; private set; } = GetFirstPlane();

        public static readonly Plane Boeing2 = new Plane( PlaneType.Boeing ,150, new DateTime(2015, 2, 3));
        public static readonly Plane Airbus = new Plane()
        {
            PlaneId = 3,
            PlaneType = PlaneType.Airbus,
            capacity = 150,
            ManufactureDate = new DateTime(2020, 11, 11)
        };

        static Plane GetFirstPlane()
        {
            var plane = new Plane();
            plane.PlaneId = 1;
            plane.PlaneType = PlaneType.Boeing;
            plane.capacity = 200;
            plane.ManufactureDate = new DateTime(2019, 12, 31);
            plane.Flight = new List<Flight>() { f1, f2 };

            return plane;
        }

        public static readonly Staff s1 = new Staff() { 
                FirstName = "captain",
                LastName = "Captain", 
                EmailAdress = "captain@gmail.com", 
                BirthDate = new DateTime(1965, 1, 1), 
                EmployementDate = new DateTime(1999, 1, 1), 
                Salary = 10000 
        };
        public static readonly Staff s2 = new Staff() { 
                FirstName = "hotess1", 
                LastName = "Hotess1", 
                EmailAdress = "hotess1@gmail.com", 
                BirthDate = new DateTime(1995, 1, 1), 
                EmployementDate = new DateTime(2019, 1, 1), 
                Salary = 5000 
        };
        public static readonly Staff s3 = new Staff() { 
                FirstName = "hotess2", 
                LastName = "Hotess2",
                EmailAdress = "hotess2@gmail.com", 
                BirthDate = new DateTime(1996, 1, 1), 
                EmployementDate = new DateTime(2018, 1, 1), 
                Salary = 6100 
        };

        public static readonly Traveller t1 = new Traveller() { 
                FirstName = "traveller1", 
                LastName = "Traveller1", 
                BirthDate = new DateTime(1980, 1, 1),
                HealthInformation = "No Troubles", 
                Nationality = "American" 
        };
        public static readonly Traveller t2 = new Traveller() { 
                FirstName = "traveller2", 
                LastName = "Traveller2", 
                BirthDate = new DateTime(1981, 1, 1), 
                HealthInformation = "Some Troubles", 
                Nationality = "French" 
        };
        public static readonly Traveller t3 = new Traveller() { 
                FirstName = "traveller3", 
                LastName = "Traveller3",
                BirthDate = new DateTime(1982, 1, 1), 
                HealthInformation = "No Troubles", 
                Nationality = "Tunisian" 
        };
        public static readonly Traveller t4 = new Traveller() { 
                FirstName = "traveller4",
                LastName = "Traveller4", 
                BirthDate = new DateTime(1983, 1, 1),
                HealthInformation = "Some Troubles",
                Nationality = "American" 
        };
        public static readonly Traveller t5 = new Traveller() { 
                FirstName = "traveller5", 
                LastName = "Traveller5", 
                BirthDate = new DateTime(1984, 1, 1),
                HealthInformation = "Some Troubles", 
                Nationality = "Spanish" 
        };

        public static readonly IList<Staff> staffs = new List<Staff>() { s1, s2, s3 };
        public static readonly IList<Traveller> travellers = new List<Traveller>() { t1, t2, t3, t4, t5 };

        public static readonly Flight f1 = new Flight() { 
                FlightId = 1,
                FlightDate = new DateTime(2022, 1, 1, 15, 10, 00),
                Destination = "Paris", 
                EffictiveArrival = new DateTime(2022, 1, 1, 17, 10, 00), 
                EstimatedDuration = 2, 
                plane = Boeing1, 
                passengers = new List<Passenger>() { s1, s2, s3 } 
        };
        public static readonly Flight f2 = new Flight() { 
                FlightId = 2, 
                FlightDate = new DateTime(2022, 2, 1, 21, 10, 00), 
                Destination = "Paris", 
                EffictiveArrival = new DateTime(2022, 2, 1, 23, 10, 00), 
                EstimatedDuration = 2, 
                plane = Boeing1, 
                passengers = new List<Passenger>() { t1, t2, t3, t4, t5 }
        };
        public static readonly Flight f3 = new Flight() { 
                FlightId = 3, 
                FlightDate = new DateTime(2022, 3, 1, 05, 10, 00), 
                Destination = "Paris", 
                EffictiveArrival = new DateTime(2022, 3, 1, 07, 10, 00), 
                EstimatedDuration = 2,
                plane = Boeing2, 
                passengers = returntrav(new List<Passenger>() { s1, s2, s3 }, 
                    new List<Passenger>() { t1, t2, t3, t4, t5 }) 
        };
        public static readonly Flight f4 = new Flight() { 
                FlightId = 4, 
                FlightDate = new DateTime(2022, 4, 1, 06, 10, 00),
                Destination = "Madrid",
                EffictiveArrival = new DateTime(2022, 4, 1, 08, 40, 00),
                EstimatedDuration = 2, 
                plane = Boeing2 
        };
        public static readonly Flight f5 = new Flight() { 
                FlightId = 5, 
                FlightDate = new DateTime(2022, 5, 1, 17, 10, 00),
                Destination = "Madrid",
                EffictiveArrival = new DateTime(2022, 5, 1, 19, 40, 00),
                EstimatedDuration = 2, plane = Airbus 
        };
        public static readonly Flight f6 = new Flight() { 
                FlightId = 6,
                FlightDate = new DateTime(2022, 6, 1, 22, 10, 00), 
                Destination = "Lisbonne",
                EffictiveArrival = new DateTime(2022, 6, 1, 23, 10, 00), 
                EstimatedDuration = 3, 
                plane = Airbus 
        };

        public static readonly IList<Flight> flights = new List<Flight>() { f1, f2, f3, f4, f5, f6 };

        public static List<Passenger> returntrav(List<Passenger> l1, List<Passenger> l2)
        {
            var passager = new List<Passenger>(l1.Count + l2.Count);

            passager.AddRange(l1);
            passager.AddRange(l2);

            return passager;
        }
    }
}
