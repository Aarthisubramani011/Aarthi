using System.Diagnostics;

namespace Aarthi.Arena.CSES._02__CodeForces
{
    internal class IQtest
    {

        public static void _IQ_test()

        {
            
            int n = int.Parse(Console.ReadLine());
            int[] oddarr = new int[n];
            int[] evenarr = new int[n];
            string[] numbers = (Console.ReadLine().Split(" "));
            int oddcount = 0;
            int evencount = 0;
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(numbers[i]);
                if (num % 2 == 0)
                {
                    evenarr[evencount] = i + 1;
                    evencount++;
                }
                else
                {
                    oddarr[oddcount] = i + 1; 
                    oddcount++;
                }
            }
            if (oddcount == 1)
            {
                Console.WriteLine(oddarr[0]);
            }
            else
            {
                Console.WriteLine(evenarr[0]);
            }

        }



    }
}