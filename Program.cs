// Author: Hassaan Anas
// Date: 2/4/2021
// Project: Methods
using System;

namespace Mehtods
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
               
                // Asks the user to write their name
                Console.WriteLine("Enter your name");

                // decalring variable input 
                string input = Console.ReadLine();

                // shows the message hello with the input

                Console.WriteLine("Hello!! " + input);

            }

            catch
            {
                Console.WriteLine("please enter your name");
                
            }

           
        }
    }
}
