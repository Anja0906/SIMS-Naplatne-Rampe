using System.Collections.Generic;
using SIMS.Model;

namespace SIMS.Repository
{
    public interface IStationsRepository
    {
        List<Station> GetStations();
        Station GetStationById(string id);
        Station GetStationByName(string name);
        Place GetPlaceById(Station station, string id);
        void Add(Station station);
        void Delete(Station station);
        void AddPlace(Station station, Place place);
        void DeletePlace(Station station, Place place);
        void UpdateStation(Station newStation);
        void UpdatePlace(Station station, Place place);
        void Save();
    }
}