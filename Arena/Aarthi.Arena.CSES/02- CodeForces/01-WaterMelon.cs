using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aarthi.Arena.CSES._02__CodeForces
{
    public class WaterMelon
    {
        public static void WaterMelon01()
        {   
            int nweight = Convert.ToInt32(Console.ReadLine());  
            if (nweight> 2 && nweight %2 == 0)
            {
                Console.WriteLine("yes");
            }
            else { 
                Console.WriteLine("no");
            }
        }

        
    }
}
