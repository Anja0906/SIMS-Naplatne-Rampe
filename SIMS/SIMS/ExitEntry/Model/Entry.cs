using System;

namespace SIMS.Model
{
    public class Entry
    {
        public DateTime TimeOfEntry { get; set; }
        public Station StationOfEntry { get; set; }
        public string NumberOfVehiclePlates { get; set; }
        public VehicleType VehicleType { get; set; }

        public Entry(DateTime timeOfEntry, Station stationOfEntry, string numberOfVehiclePlates, VehicleType vehicleType)
        {
            TimeOfEntry = timeOfEntry;
            StationOfEntry = stationOfEntry;
            NumberOfVehiclePlates = numberOfVehiclePlates;
            VehicleType = vehicleType;
            
        }

        public Entry()
        {
        }
    }
}