using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aarthi.Arena.CSES._02__CodeForces
{
    public class _03_Team
    {
        public static void _Team()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int tmp = 0;
                string ans= Console.ReadLine();
              
                 for (int j=0; j< ans.Length; j++)
                {
                    if (ans[j] == '1' )
                    {
                        tmp += 1;

                    }
                    else
                    {
                        continue;
                    }
                 }

                 if (tmp >= 2){
                    result += 1;
                 }
                

            }
            Console.WriteLine(result);

        }
    }
}
