using System;
using System.Collections.Generic;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    public class StationsController : IStationsController
    {
        private StationsRepository _stationsRepository;
        private MainRepository _mainRepository;

        public StationsController(MainRepository mainRepository)
        {
            _stationsRepository = mainRepository.StationsRepository;
            _mainRepository = mainRepository;
        }
        
        public List<Station> GetStations()
        {
            return _stationsRepository.GetStations();
        }

        public void AddStation(Station station)
        {
            _stationsRepository.Add(station);
        }

        public void DeleteStation(Station station)
        {
            _stationsRepository.Delete(station);
        }

        public List<Place> GetPlaces(Station station)
        {
            return station.BillingPlaces;
        }

        public void DeletePlace(Station station, Place place)
        {
            _stationsRepository.DeletePlace(station, place);
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
        
        public Station GetStationById(string id)
        {
            foreach (Station station in _stationsRepository.GetStations())
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
            foreach (Station station in _stationsRepository.GetStations())
            {
                if (station.Name.Equals(name))
                {
                    return station;
                }
            }

            return null;
        }
        
        public void UpdatePlace(Station station, Place place)
        {
            _stationsRepository.UpdatePlace(station, place);
        }
        public void AddPlace(Station station, Place place)
        {
            _stationsRepository.AddPlace(station, place);
        }

        public void UpdateStation(Station station)
        {
            _stationsRepository.UpdateStation(station);
        }

        public string getIdFromListBox(string wholeString)
        {
            wholeString = wholeString.Replace("(", String.Empty);
            string[] tokens = wholeString.Split(',');
            return tokens[0];
        }

        public void RepairPlace(Station station, string id)
        {
            Place placeForRepairation = GetPlaceById(station, id);
            placeForRepairation.IsInUse = true;
            UpdatePlace(station, placeForRepairation);
        }
        
        public void Save()
        {
            _mainRepository.Save();
        }
    }
}