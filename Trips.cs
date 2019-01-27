using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusValidator
{
    public class Trips
    {
        public string TypeBus { get; set; }
        public int PriceTripBus { get; set; }
        public int SaleForTripBus { get; set; }

        public Trips()
        {
            PriceTripBus = 0;
            SaleForTripBus = 0;
        }
    }
}
