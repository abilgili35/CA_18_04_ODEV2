using CA_18_04_ODEV2.Abstracts;
using CA_18_04_ODEV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV2.Concretes
{
    public class BusTicket : ITicket
    {
        public TicketType TicketType { get; set; }
        public int Distance { get ; set ; }

        public BusTicket(int distance) 
        {
            Distance = distance;
            TicketType = TicketType.Bus;
        }

        public decimal CalculatePrice()
        {
            return Distance * 2.5M;
        }
    }
}
