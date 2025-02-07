using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{

        partial class Country
        {
            public static string Countryname = " india";
            public void CountryMethod()
            {
                Console.WriteLine("Country is" + Countryname);
            }
        }
        partial class Country
        {
            public static string ParentCountryNm = "India";

            public void ParentCountryMethod()
            {
                Console.WriteLine("Country is" + Countryname);
            }
        }
    
}
