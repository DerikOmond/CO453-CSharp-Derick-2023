using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public void Run()
        {
            //step1 - Input needed from the user

            Console.Write("Enter no. of miles: ");
           string input = Console.ReadLine(); 
           int miles = Convert.ToInt32(input);
           Console.WriteLine("Miles entered: " +miles);

           //step 2 - convert miles into feet

            const int MILES_TO_FEET = 5280;
           int feet = miles*MILES_TO_FEET;

           //step 3 - print feet

           Console.WriteLine(miles + " miles is " + feet + " feet.");
        }
    }
}
