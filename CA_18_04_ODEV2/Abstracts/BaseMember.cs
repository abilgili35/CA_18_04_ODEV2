using CA_18_04_ODEV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV2.Abstracts
{
    public abstract class BaseMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<ITicket> Tickets { get; set; }

        public BaseMember(string firstName, string lastName, string email) 
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;  

            Tickets = new List<ITicket>();
        }

        // Create Ticket BaseMember abstract classi icerisindeki FactoryMethod u temsil eder
        // BaseMember dan turetilen class lar ayni zamanda birer FactoryClass tir ve ITicket
        // tipinde bir classtan nesneler olusturabilir.
        public abstract ITicket CreateTicket(TicketType ticketType, int distance);

        public void AddTicket(ITicket ticket)
        {
            if (ticket != null)
            {
                Tickets.Add(ticket);
            }
        }

        public override string ToString()
        {
            string returnString = "";

            returnString += $"Ad : {FirstName} Soyad : {LastName} Email : {Email}";

            returnString += "\n\n-------------------- BILETLER --------------------\n\n";

            foreach(ITicket ticket in Tickets)
            {
                returnString += $"Mesafe : {ticket.Distance} Ucret : {ticket.CalculatePrice()}";

                switch(ticket.TicketType)
                {
                    case TicketType.Bus:
                        returnString += " Bilet Turu : Otobus Bileti\n";
                        break;
                    case TicketType.Train:
                        returnString += " Bilet Turu : Tren Bileti\n";
                        break;
                    case TicketType.Airplane:
                        returnString += " Bilet Turu : Ucak Bileti\n";
                        break;

                }
 
            }

            returnString += "\n";

            return returnString;
        }
    }
}
