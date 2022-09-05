using System;

namespace SIMS.Model
{
    public class Section
    {
        public string Entry { get; set; }
        public string Exit{ get; set; }
        public double I{ get; set; }
        public double Ia{ get; set; }
        public double II{ get; set; }
        public double III{ get; set; }
        public double IV{ get; set; }
        public DateTime DateOfValidity { get; set; }
        public int Kilometers { get; set; }


        public Section(string entry, string exit, double i, double ia, double ii, double iii, double iv, DateTime dateOfValidity, int kilometers)
        {
            Entry = entry;
            Exit = exit;
            I = i;
            Ia = ia;
            II = ii;
            III = iii;
            IV = iv;
            DateOfValidity = dateOfValidity;
            Kilometers = kilometers;
        }
    }
    
}