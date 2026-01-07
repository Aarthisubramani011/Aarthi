using System;


namespace Aarthi.Arena.CSES
{
    internal class _05_Permutations
    {
        public void PrintPattern()
        {
            int n = 10;

            if (n <= 3)
            {
                Console.WriteLine("No Solution");

            }
            else
            {
                
                for (int i = n - 1; i > 0; i -= 2)
                {
                    Console.Write(i + " ");
                }

                for (int i = n; i >= 1; i -= 2)
                {
                    Console.Write(i + " ");
                }

               
            }
        }
      

    }
}
