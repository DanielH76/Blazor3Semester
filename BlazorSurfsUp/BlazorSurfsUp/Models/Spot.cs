using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSurfsUp.Models
{
    public class Spot
    {
        public IEnumerable<SpotComment> SpotComments { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Name { get; set; }

        public List<int> Ratings { get; set; }

        public Spot(double lat,
                    double lon,
                    string name)
        {
            Lat = lat;
            Lon = lon;
            Name = name;
        }
    }
}
