using System;

namespace Tutorials
{
    internal class ConsoleClass
    {
        public static void Console_Class() {

            // static class cannot be inherited 
            // Everything inside the class has static property
            Console.WriteLine("Enter a Key");
            int var1 = Console.Read(); //The Read method will allow you to enter a character and will return the ASCII value of that character.
            Console.WriteLine($"ASCII Value of the Entered Key is: {var1}");

            Console.WriteLine("Enter Another Key");
            ConsoleKeyInfo var2 = Console.ReadKey();

           //The ReadKey method also allows you to enter a key and it will return the key information such as what key you pressed,

            Console.WriteLine($"\nEntered Key: {var2.Key} KeyChar:{var2.KeyChar} ASCII:{(int)var2.KeyChar}");

            Console.WriteLine("Press Any Key to Terminate");

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = " understanding the Console class";
            Console.WriteLine("BackgroundColor: Blue");
            Console.WriteLine("ForegroundColor: White");
            Console.WriteLine("Title: Understanding Console Class");
            Console.Beep(); // create an beep sound
            Console.ReadKey();
        }
          
    }
}
