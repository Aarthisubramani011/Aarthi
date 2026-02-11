using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aarthi.Arena.CSES._02__CodeForces
{
    public class Petya_strings
    {
        public static void Main()
        {
            string? str1 = Console.ReadLine()?.ToLower();
            string? str2 = Console.ReadLine()?.ToLower();

            //Console.WriteLine(str1.CompareTo(str2));

            if (str1 == str2)
            {
                Console.WriteLine(0);

            }
            else if (str1.CompareTo(str2) < 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
