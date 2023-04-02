using System;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lectures lectures1 = new Lectures();
            lectures1.SetEvent("Multistake Fireside", "Lecture", "Young people between 11 and 18 years old attend", "Sunday, April 16th 2023", "6:00pm");
            lectures1.SetLectures("Mission President", 350);
        
            Address address1 = new Address();
            address1.SetAddress("1320 Ridgeland Avenue", "Naperville", "IL", "USA");

            Console.WriteLine("******************** EVENT I ********************");        
            Console.WriteLine("");
            Console.WriteLine("********** Standard Details **********");
            Console.WriteLine("");
            lectures1.GetStandardDetails();

            Console.WriteLine("");
            Console.WriteLine("********** Full Details **********");
            Console.WriteLine("");
            lectures1.GetFullDetailsLectures();
            Console.WriteLine($"Address: {address1.GetAddress()}");

            Console.WriteLine("");
            Console.WriteLine("********** Short Details **********");
            Console.WriteLine("");
            lectures1.GetShortDescription();

        // *********************************************************************************************************************

            OutdoorGatherings OutGat1 = new OutdoorGatherings();
            OutGat1.SetEvent("Ward Youth Temple Trip", "Outdoor Gathering", "Young people between 11 and 18 years old attend", "Wednesday, April 12th 2023", "7:00pm");
            OutGat1.SetWeather("41F, Partly Cloudy");
            
            Address address2 = new Address();
            address2.SetAddress("4151 W Lake Ave", "Glenview", "IL", "USA");
            
            Console.WriteLine("");
            Console.WriteLine("******************** EVENT II ********************"); 
            Console.WriteLine("");
            Console.WriteLine("********** Standard Details **********");
            Console.WriteLine("");
            OutGat1.GetStandardDetails();
            
            Console.WriteLine("");
            Console.WriteLine("********** Full Details **********");
            Console.WriteLine("");
            OutGat1.GetFullDetailsLectures();
            Console.WriteLine($"Address: {address2.GetAddress()}");

            Console.WriteLine("");
            Console.WriteLine("********** Short Details **********");
            Console.WriteLine("");
            OutGat1.GetShortDescription();


        // *********************************************************************************************************************

            Receptions receptions1 = new Receptions();
            receptions1.SetEvent("New Year's Party", "Reception", "Let's receive the New Year together!", "December 31st, 2023", "7:00pm");
            receptions1.SetEmail("acps_88@hotmail.com");
            
            Address address3 = new Address();
            address3.SetAddress("'Chicago Marriott Downtown Magnificient Mile' - 540 Michigan Ave", "Chicago", "IL", "USA");
            
            Console.WriteLine("");
            Console.WriteLine("******************** EVENT III ********************"); 
            Console.WriteLine("");
            Console.WriteLine("********** Standard Details **********");
            Console.WriteLine("");
            receptions1.GetStandardDetails();
            
            Console.WriteLine("");
            Console.WriteLine("********** Full Details **********");
            Console.WriteLine("");
            receptions1.GetFullDetailsReception();
            Console.WriteLine($"Address: {address3.GetAddress()}");

            Console.WriteLine("");
            Console.WriteLine("********** Short Details **********");
            Console.WriteLine("");
            receptions1.GetShortDescription();
            Console.WriteLine("");
        }
    }
}