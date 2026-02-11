using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class Conversions
    {
        public static void Conversion()
        {
            // smaller datatype  --> larger datatype
            int num = 500;
            double numdouble = num;

            //larger datatype to smaller datatype
            double numdouble2 = 50.67;
            int num2 = (int) numdouble2;

            int num3 = 100;
            byte bytenum = (byte)num3;

            int num4 = 500;
            byte bytenum2 = (byte)num4;//  here it execeeds the conversion range (0-255)

            //using helper method
            double d = 123.45;
            string str = Convert.ToString(d);
            Console.WriteLine(str);
            int num5 = Convert.ToInt16(d);
            Console.WriteLine(num5);
            //int num6 = Convert.ToInt64(str); here it fails to covert 

            // using Parse method
            // int num6 = int.Parse(str); here it again fails

            // using try parse
            bool num6 = int.TryParse(str, out int i2);
            Console.WriteLine(i2);
            //but the conversion answer is 0 it fails to convert because decimal 8yte ---> int 4byte
            




        }
    }
}
