/* 
    Writer: Kaley Liburd
    Due Date: 02/07/2020
    Comments: This project will demonstrate how methods work. A method is
     a code block that contains a series of statements. A program causes the 
     statements to be executed by calling the method and specifying any required method arguments.

     */

using System;

namespace Deliverable_3_Methods
{
    public class Program
    {

        string name;

        public void RetrieveName()
        {
            Console.WriteLine("Please type your full name!");
            name = Console.ReadLine();

            // Space
            Console.WriteLine("\n");

            // Here the information inputted will be displayed
            Console.WriteLine("Hello " + name + " !");
            Console.ReadLine();
        } // End of RETRIEVE-NAME method

        static void Main(string[] args)
        {
            try
            {
            
                Program p = new Program();
                p.RetrieveName();
                Console.ReadLine();
            }
            

           catch
            {
            
             // Pause and wait for the user hit a key to exit the program
            Console.WriteLine("Please hit any key to exit the program...");
            Console.ReadKey(true);
            } // End of CATCH statement
           

        } // End of PROGRAM (RETRIEVE-NAME)
    }
}
