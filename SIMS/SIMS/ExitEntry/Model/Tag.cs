namespace SIMS.Model
{
    public class Tag
    {
        public string Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public string NumberOfVehiclePlates { get; set; }
        public double BalanceOfMoney { get; set; }


        public Tag(string id, VehicleType vehicleType, string numberOfVehiclePlates, double balanceOfMoney)
        {
            Id = id;
            VehicleType = vehicleType;
            NumberOfVehiclePlates = numberOfVehiclePlates;
            BalanceOfMoney = balanceOfMoney;
        }
    }
}