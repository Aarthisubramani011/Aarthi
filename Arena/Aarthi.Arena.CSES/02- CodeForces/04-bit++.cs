using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aarthi.Arena.CSES._02__CodeForces
{
    public class _04_bit__
    {
        public static void _bit__()
        {
            int X = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                string str = Console.ReadLine();
                if (str == "X++" )
                {
                    X += 1;
                }
                else if( str == "++X")
                {
                    X += 1;
                }
                else if (str == "--X")
                {
                    X -= 1;
                }
                else if(str == "X--")
                {
                    X -= 1;
                }
            }
            Console.WriteLine(X);
        }
    }
}
