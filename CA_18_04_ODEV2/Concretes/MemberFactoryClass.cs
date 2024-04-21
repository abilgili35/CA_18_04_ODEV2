using CA_18_04_ODEV2.Abstracts;
using CA_18_04_ODEV2.Enums;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV2.Concretes
{
    public class MemberFactoryClass
    {
        public BaseMember FactoryMethod(MembershipType membershipType, string firstName, string lastName, string email)
        {
            BaseMember member = null;

            switch(membershipType)
            {
                case MembershipType.Basic:
                    member = new BasicMember(firstName, lastName, email);
                    break;
                case MembershipType.Premium:
                    member = new PremiumMember(firstName, lastName, email);
                    break;
                case MembershipType.Diamond:
                    member = new DiamondMember(firstName, lastName, email);
                    break;
            }

            return member;
        }
    }
}
