using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class StationsRepository : IStationsRepository
    {
        private List<Station> _stations;
        private List<Station> _deletedStations;

        public StationsRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Stations.json");
            List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(json);
            _stations = stations;
            string json1 = File.ReadAllText(@"..\..\Data\DeletedStations.json");
            List<Station> stations2 = JsonConvert.DeserializeObject<List<Station>>(json1);
            _deletedStations = stations2;
        }

        public List<Station> GetStations()
        {
            return _stations;
        }
        
        public Station GetStationById(string id)
        {
            foreach (Station station in _stations)
            {
                if (station.Id.Equals(id))
                {
                    return station;
                }
            }

            return null;
        }
        
        public Station GetStationByName(string name)
        {
            foreach (Station station in _stations)
            {
                if (station.Name.Equals(name))
                {
                    return station;
                }
            }

            return null;
        }
        
        public Place GetPlaceById(Station station, string id)
        {
            foreach (Place place in station.BillingPlaces)
            {
                if (place.Id.Equals(id))
                {
                    return place;
                }
            }

            return null;
        }

        public void Add(Station station)
        {
            _stations.Add(station);
        }

        public void Delete(Station station)
        {
            _deletedStations.Add(station);
            _stations.Remove(station);
        }

        public void AddPlace(Station station, Place place)
        {
            station.BillingPlaces.Add(place);
            UpdateStation(station);
        }

        public void DeletePlace(Station station, Place place)
        {
            station.BillingPlaces.Remove(place);
            UpdateStation(station);
        }

        public void UpdateStation(Station newStation)
        {
            Station oldStation = GetStationById(newStation.Id);
            Delete(oldStation);
            Add(newStation);
        }
        
        public void UpdatePlace(Station station, Place place)
        {
            Place oldPlace = GetPlaceById(station, place.Id);
            station.BillingPlaces.Remove(oldPlace);
            station.BillingPlaces.Add(place);
            UpdateStation(station);
        }
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Stations.json", JsonConvert.SerializeObject(_stations));
            File.WriteAllText(@"..\..\Data\DeletedStations.json", JsonConvert.SerializeObject(_deletedStations));
        }
    }
}