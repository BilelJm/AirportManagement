using AM.ApplicationCore;
using AM.ApplicationCore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Console
{
    public class Chap2
    {
        public static ShowLine showLine = System.Console.WriteLine;

        /*public static void Test1()
        {
            FlightService flightService = new FlightService(InMemorySource.flights, showLine);
            flightService.ShowFlights("Destination ","Paris");
            flightService.ShowFlights("Destination ", "Madrid");
            flightService.ShowFlights("FlightId ", "3");
        }*/

        public static void Test2()
        {
            FlightService flightService = new FlightService(InMemorySource.flights, showLine);

            flightService.GetFlightsSortedByDuration().ShowList("GetFlightsSortedByDuration", showLine);

            flightService.GetDurationsInMinutes().ShowList("GetDurationsInMinutes", showLine);

            flightService.GetDurationsInMinutesLINQ().ShowList("GetDurationsInMinutesLIN", showLine);
            
            flightService.GetPassengerTypes(3).ShowList("GetPassengerTypes", showLine);

            flightService.GetDurationsInMinutesLINQ().ShowList("GetDurationsInMinutesLIN", showLine);

            new float[] { flightService.GetDurationsAverage() }.ShowList("GetDurationsAverage", showLine);
        }
    }
}
