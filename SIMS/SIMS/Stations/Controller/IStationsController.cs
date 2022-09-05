using System.Collections.Generic;
using SIMS.Model;

namespace SIMS.Controller
{
    public interface IStationsController
    {
        List<Station> GetStations();
        void AddStation(Station station);
        void DeleteStation(Station station);
        List<Place> GetPlaces(Station station);
        void DeletePlace(Station station, Place place);
        Place GetPlaceById(Station station, string id);
        Station GetStationById(string id);
        Station GetStationByName(string name);
        void UpdatePlace(Station station, Place place);
        void AddPlace(Station station, Place place);
        void UpdateStation(Station station);
        string getIdFromListBox(string wholeString);
        void RepairPlace(Station station, string id);
        void Save();
    }
}