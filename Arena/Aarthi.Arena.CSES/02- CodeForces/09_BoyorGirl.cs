using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aarthi.Arena.CSES._02__CodeForces
{
    public class YESorYES
    {
        public static void YESorYES__()
        {
            
            string user = Console.ReadLine();
            HashSet<char> set = new HashSet<char>();
            foreach ( char c in user)
            {
                set.Add(c);
            }
          
            if (set.Count % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!\r\n");

            }
            else
            {
                Console.WriteLine("IGNORE HIM!\r\n");
            }
        }
    }
}
