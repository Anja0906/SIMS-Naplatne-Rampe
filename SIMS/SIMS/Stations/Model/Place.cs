using System.Text;

namespace SIMS.Model
{
    public class Place
    {
        public string Id { get; set; }
        public BillingType BillingType { get; set; }
        public VehicleType VehicleType { get; set; }
        public bool Ramp { get; set; }
        public bool IsInUse { get; set; }

        public Place(string id, BillingType billingType, VehicleType vehicleType)
        {
            Id = id;
            BillingType = billingType;
            VehicleType = vehicleType;
            Ramp = false;
            IsInUse = true;
        }

        public Place()
        {
            Id = "";
            BillingType = BillingType.Electronic;
            VehicleType = VehicleType.Car;
            Ramp = false;
            IsInUse = true;
        }
        public override string ToString()
        {
            return "Id: " + Id + " " + "BillingType" + BillingType + " " + "VehicleType" + VehicleType + " " + "Is raised:" + Ramp + " " + "Is in use: " + IsInUse;
        }
    }
}