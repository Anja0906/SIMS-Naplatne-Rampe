using System.Collections.Generic;

namespace SIMS.Model
{
    public class Station
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public List<Place> BillingPlaces { get; set; }
        
        public Station(string id, string name, List<Place> billingPlaces)
        {
            Id = id;
            Name = name;
            BillingPlaces = billingPlaces;
        }

        private string PlacesToString()
        {
            string places = "";
            foreach (Place place in BillingPlaces)
            {
                places += place.ToString() + "\n";
            }

            return places;
        }

        public override string ToString()
        {
            return "Id: " + Id + " " + "Name: " + Name + " " + PlacesToString();
        }
    }
}