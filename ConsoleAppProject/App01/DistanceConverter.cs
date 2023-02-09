using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This console app allows users to convert between units of distance
    /// </summary>
    /// <author>
    /// Derick Omondi Version 0.1
    /// </author>
    public class DistanceConverter
    {
        /// <running>
        /// In order to begin the process of converting units of distances, the 'Run'
        /// method will be called as a way of calling the other methods relevent to
        /// the class.
        /// </running>
        public void Run()
        {
            Heading();
            Console.ReadLine();
        }

        public void Heading()
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("-----------This console app allows you to convert between units of measurements.-----------");
            Console.WriteLine("===========================================================================================");
        }
    }
}
