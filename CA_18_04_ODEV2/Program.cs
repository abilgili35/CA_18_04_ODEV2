using CA_18_04_ODEV2.Abstracts;
using CA_18_04_ODEV2.Concretes;
using CA_18_04_ODEV2.Enums;
using CA_18_04_ODEV2.Singleton;

namespace CA_18_04_ODEV2 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<BaseMember> list = new List<BaseMember>();
            MemberFactoryClass memberFactoryClass = MemberFactorySingleton.MemberFactoryClass;

            BaseMember member1 = memberFactoryClass.FactoryMethod(MembershipType.Basic, "Aziz", "Bilgili", "abilgili@gmail.com");
            BaseMember member2 = memberFactoryClass.FactoryMethod(MembershipType.Premium, "Fatih", "Gunalp", "fgunalp@gmail.com");
            BaseMember member3 = memberFactoryClass.FactoryMethod(MembershipType.Diamond, "Ali", "Veli", "aveli");

            member1.AddTicket(member1.CreateTicket(TicketType.Bus, 200));
            member1.AddTicket(member1.CreateTicket(TicketType.Bus, 400));
            member1.AddTicket(member1.CreateTicket(TicketType.Train, 200));

            member2.AddTicket(member2.CreateTicket(TicketType.Bus, 400));
            member2.AddTicket(member2.CreateTicket(TicketType.Train, 500));
            member2.AddTicket(member2.CreateTicket(TicketType.Airplane, 200));

            member3.AddTicket(member3.CreateTicket(TicketType.Bus, 600));
            member3.AddTicket(member3.CreateTicket(TicketType.Train, 500));
            member3.AddTicket(member3.CreateTicket(TicketType.Airplane, 700));

            list.Add(member1);
            list.Add(member2);
            list.Add(member3);

            foreach(BaseMember member in list)
            {
                Console.WriteLine(member.ToString());
            }

            Console.Read();
        }
    }
}
