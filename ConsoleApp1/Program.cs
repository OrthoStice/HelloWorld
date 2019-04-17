using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("What would you like me to say?");
            string _userInput = Console.ReadLine();
            //create a string called userInput give it the value of what is Typed in
            Console.WriteLine("You asked me to say: " + _userInput);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
