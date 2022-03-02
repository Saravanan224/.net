using System;
using LibraryClassFile;

namespace KumaranConsoleApp1
{
    class TravelSupport
    {
        static void Main(string[] args)
        {
            //Only one object I created (only one obj ref is there)
            CitiesCore RailwayStations = new CitiesCore();
            RailwayStations[0] = "Dindigul (DG)";
            RailwayStations[1] = "Hyderabad (HYB)";
            RailwayStations[2] = "Chennai Egmore (MS)";
            RailwayStations[3] = "KSR Bangalore (SBC)";
            RailwayStations[1500] = "Invalid Station1";
            RailwayStations[-100] = "Invalid Station2";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(RailwayStations[i] ?? "Not found");
            }
            Console.ReadKey();
        }

    }
}
