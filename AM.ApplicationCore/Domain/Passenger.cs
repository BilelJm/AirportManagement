using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public IList<Flight> flights { get; set; }

        public DateTime BirthDate { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public string TelNumber { get; set; }


        public virtual string PassngerType { get { return " Unknown passenger type "; }}
        public override string ToString()
        {
            return "Passenger: "
                + "BirthDate: " + BirthDate + ", " + "EmailAddress: " + EmailAdress +
                ", " + "FirstName: " + FirstName + ", " + "LastName: " + LastName + 
                ", " + "PassportNumber: " + PassportNumber + ", " + 
                "TelNumber: " + TelNumber + 
                "Flights: " + flights;
            
        }

    }
}
