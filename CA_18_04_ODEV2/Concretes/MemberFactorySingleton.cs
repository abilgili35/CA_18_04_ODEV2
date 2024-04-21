using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CA_18_04_ODEV2.Concretes;

namespace CA_18_04_ODEV2.Singleton
{
	// MemberFactorySingleton uygulama icerisinde MemberFactoryClass sinifindan tek bir instance alinabilmesine 
	// izin veren Singleton Pattern class idir.
    class MemberFactorySingleton
	{

		private static MemberFactoryClass _memberFactory;

		public static MemberFactoryClass MemberFactoryClass
		{

			get
			{
				if (_memberFactory == null)
				{
					_memberFactory = new MemberFactoryClass();
				}

				return _memberFactory;
			}

		}

		private MemberFactorySingleton() 
        {
        }

        

       


    }
}
