using CA_18_04_ODEV2.Abstracts;
using CA_18_04_ODEV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV2.Concretes
{
    public class TrainTicket : ITicket
    {
        public TicketType TicketType { get ; set ; }
        public int Distance { get ; set ; }

        public TrainTicket(int distance) 
        {
            Distance = distance ;
            TicketType = TicketType.Train;
        }

        public decimal CalculatePrice()
        {
            return Distance * 1.5M;
        }

        
    }
}
