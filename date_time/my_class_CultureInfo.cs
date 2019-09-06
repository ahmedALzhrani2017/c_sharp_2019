using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    class my_class_CultureInfo
    {
        public static void ss()
        {

            // Displays several properties of the neutral cultures.
            Console.WriteLine("CULTURE ISO ISO WIN DISPLAYNAME                              ENGLISHNAME");
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
            {
                Console.Write("{0,-7}", ci.Name);
                Console.Write(" {0,-3}", ci.TwoLetterISOLanguageName);
                Console.Write(" {0,-3}", ci.ThreeLetterISOLanguageName);
                Console.Write(" {0,-3}", ci.ThreeLetterWindowsLanguageName);
                Console.Write(" {0,-40}", ci.DisplayName);
                Console.WriteLine(" {0,-40}", ci.EnglishName);

            }
        }
    }
}
