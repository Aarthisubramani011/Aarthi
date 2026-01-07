// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Runtime.CompilerServices;
namespace Aarthi.Arena.CSES
{
    class MissingNumber
    {
        public static void findmissing()
        {

            Console.Write("Enter an number of values:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] nInput = new int[n - 1];
            for (int i = 0; i<nInput.Length; i++)
            {
                Console.Write($" Enter value{i + 1}::");
                nInput[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" the missing value is");
            for (int j = 1; j <= n; j++)
            {
                bool found = false;
                for (int k = 0; k<nInput.Length; k++)
                {

                    if (j == nInput[k])
                    {
                        found = true;
                        break;
                    }

                 }
                if (!found)
                {
                    Console.WriteLine(" the missing value is" + j);
                }


            }


        }
    }
}

