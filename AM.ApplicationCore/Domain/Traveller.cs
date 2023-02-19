﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public override string PassngerType { get { return "Traveller passenger type "; } }
        public override string ToString()
        {
            return base.ToString() + "HealthInformation: " + HealthInformation + " ," + "Nationaliy: " + Nationality;
        }
    }
}