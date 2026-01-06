using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aarthi.Arena.CSES
{
    class _04_IncreaceArray
    {
        public static void IncreasingArray()
        {
            Console.Write("Enter an numbeer of values:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} values");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter value{i}:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int  moves = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    moves += arr[i - 1] - arr[i];
                    arr[i] = arr[i - 1];
                }
                
            }
            Console.WriteLine("No. of moves ", moves);




        }
    }
}
      
              
          

