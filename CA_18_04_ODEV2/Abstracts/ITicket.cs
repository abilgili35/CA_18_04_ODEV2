using CA_18_04_ODEV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV2.Abstracts
{
    public interface ITicket
    {
        int Distance { get; set; }
        TicketType TicketType { get; set; }
        decimal CalculatePrice();
    }
}
