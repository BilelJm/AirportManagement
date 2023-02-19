using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
        
    {
        public IList<Flight> Flight
        { get; set; }
        public int capacity { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public int PlaneId { get; set; }

        public PlaneType PlaneType { get; set; }
        public Plane()
        {
        }

        


        public Plane( PlaneType planeType, int capacity, DateTime? manufactureDate)
        {
      
            PlaneType = planeType;
            this.capacity = capacity;
            ManufactureDate = manufactureDate;
            
        }

        public override string ToString()
        {
            return  "Plane : Plane id "+ PlaneId +
                    " , Plane Type "+ PlaneType+
                    " , Capacity "+capacity+
                    " , Manufacture Date "+ManufactureDate;
        }
        



    }
    
}
