using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class Datatypes
    {
        public static void Data_types()
        {
                byte b1 = 66; // range  0 - 255
                Console.WriteLine($"Decimal: {b1}");
                Console.WriteLine($"ASCII Character: {(char)b1}");
                Console.WriteLine($"Byte Min: {byte.MinValue}, Max: {byte.MaxValue}");
                Console.WriteLine($"Byte Size: {sizeof(byte)} byte");

                sbyte sb1 = 66;
                sbyte sb2 = -100; // range -128 to 127 or their equivalent ASCII values 
                Console.WriteLine($"\nDecimal: {sb1}");
                Console.WriteLine($"ASCII Character: {(char)sb1}");
                Console.WriteLine($"Negative Value Example: {sb2}");
                Console.WriteLine($"SByte Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
                Console.WriteLine($"SByte Size: {sizeof(sbyte)} byte");


                char ch = 'a';
                Console.WriteLine($"Equivalent Number :{(byte)ch}");
                Console.WriteLine($"Char Minimum :{(int)char.MinValue} and {(int)char.MaxValue}");
                Console.WriteLine($"char Size :{sizeof(char)} Byte");

            string str = "asabc";
            Console.WriteLine($"String Size :{str.Length  * sizeof(char)}"); 
       
    }
    }
}
