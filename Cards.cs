using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusValidator
{
    public class Cards
    {
        public string TypeCard { get; set; }
        public int BalansCard { get; set; }
        public int IdCard { get; set; }
        public Cards()
        {
            IdCard = 0;
            BalansCard = 0;
        }
    }
}
