using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class _04_Variables
    {
        const float PI = 3.14f;   // constant
        static int x = 100;       // static field
        int y = 200;              // instance field
        readonly int z;    // readonly field
        readonly int w = 60;
        public _04_Variables()
        {

        }
        public _04_Variables(int a)
        {
            x = a;   // modifies static field (shared) In such case use non static 
            // PI = 3.78; //  compile-time error
            y = a;   // modifies instance field
            z = a;   // allowed because it's inside constructor
        }
        public _04_Variables(int a , int b)
        {
            x = a;
            z = b;
        }
        public void Variables()
        {


            // Console.WriteLine(y); to call the non-static variable u need to  create the instance 
            Console.WriteLine(x); // static variable is called here directly because the Variable() is inside static main()
            _04_Variables obj1 = new _04_Variables();
            Console.WriteLine(obj1.z); // here the answer is 0 because the readonly of the datatype holds 0 by default 
            Console.WriteLine(obj1.w);
            _04_Variables obj = new _04_Variables(500);
            Console.WriteLine(_04_Variables.x); // static via class name
            Console.WriteLine(obj.y);           // instance via object
            Console.WriteLine(obj.z);           // readonly via object

            _04_Variables obj2 = new _04_Variables(10 ,20); //in this case the readonly dont have any default value the value needed to be passed .

        }


    }
}
