using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
       Boing, Airbus
    }
    public class Plane
    {

        [Range(0, int.MaxValue)]
        public int Capacity
        { get; set; }
        public DateTime ManufactureDate { get; set; }

      
        public PlaneType PlaneType{ get; set;}

        public int PlaneId { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

        public virtual ICollection<Passenger>Passengers{ get; set; }


        public override string ToString()
        {
            return $"plane: PlaneId {PlaneId}, ManufactureDate{ManufactureDate}";
        }
    }

}
