using System;
using System.Globalization;

namespace SIMS.Model
{
    public class Exit
    {
        public DateTime TimeOfExit { get; set; }
        public Station StationOfEntry { get; set; }
        
        public Station StationOfExit { get; set; }
        
        public double Price { get; set; }
        public string NumberOfVehiclePlates { get; set; }
        public VehicleType VehicleType { get; set; }

        public Exit(DateTime timeOfExit, Station stationOfEntry, Station stationOfExit, double price, string numberOfVehiclePlates, VehicleType vehicleType)
        {
            TimeOfExit = timeOfExit;
            StationOfEntry = stationOfEntry;
            StationOfExit = stationOfExit;
            Price = price;
            NumberOfVehiclePlates = numberOfVehiclePlates;
            VehicleType = vehicleType;
        }

        public Exit()
        {
        }

        public override string ToString()
        {
            return NumberOfVehiclePlates + " " + StationOfEntry.Name + " " + StationOfExit.Name + " " + Price + " " + VehicleType + " " + TimeOfExit.ToString("G",CultureInfo.GetCultureInfo("de-DE"));
        }
    }
}