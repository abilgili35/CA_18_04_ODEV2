using CA_18_04_ODEV2.Abstracts;
using CA_18_04_ODEV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV2.Concretes
{
    public class DiamondMember : BaseMember
    {
        public DiamondMember(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
        }

        public override ITicket CreateTicket(TicketType ticketType, int distance)
        {
            ITicket ticket = null;

            switch (ticketType)
            {
                case TicketType.Bus:
                    ticket = new BusTicket(distance);
                    break;
                case TicketType.Train:
                    ticket = new TrainTicket(distance);
                    break;
                case TicketType.Airplane:
                    ticket = new AirplaneTicket(distance);
                    break;
            }

            return ticket;
        }
    }
}
