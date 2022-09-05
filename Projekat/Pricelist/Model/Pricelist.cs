using System;
using System.Collections.Generic;

namespace SIMS.Model
{
    public class Pricelist
    {
        public DateTime EffectiveDate;
        public double Coefficient;
        public List<Section> Sections;
        public List<string> Places;

        public Pricelist(DateTime effectiveDate, double coefficient, List<Section> sections, List<string> places)
        {
            EffectiveDate = effectiveDate;
            Coefficient = coefficient;
            Sections = sections;
            Places = places;
        }

        public Pricelist()
        {
            EffectiveDate = DateTime.Now;
            Coefficient = 1.2;
        }

        public List<Section> GetSections()
        {
            return Sections;
        }

        public List<string> GetPlaces()
        {
            return Places;
        }

        public void AddSection(Section section)
        {
            Sections.Add(section);
        }
        
        public void AddPlace(string place)
        {
            Places.Add(place);
        }
        

        public Section Find(string entry, string exit)
        {
            foreach (Section section in Sections)
            {
                if (section.Entry.Equals(entry) && section.Exit.Equals(exit))
                {
                    return section;
                }
                
            }

            return null;
        }

        public double CalculatePrice(string entry, string exit, VehicleType vehicleType)
        {
            double price = 0.0;
            foreach (Section section in Sections)
            {
                if (section.Entry.Equals(entry) && section.Exit.Equals(exit))
                {
                    switch (vehicleType)
                    {
                        case VehicleType.Motorcycle:
                            price = section.Ia;
                            break;
                        case VehicleType.Car:
                            price = section.I;
                            break;
                        case VehicleType.Bus:
                            price = section.III;
                            break;
                        case VehicleType.PassengerTruck:
                            price = section.II;
                            break;
                        case VehicleType.Truck:
                            price = section.IV;
                            break;
                        default:
                            price = 100.00;
                            break;
                    }
                }
            }
            

            return price;
        }
    }
    
    
}