using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeedGUI.Environment
{
    public class Location
    {
        private string cityName;
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        private string regionName;
        public string RegionName
        {
            get { return regionName; }
            set { regionName = value; }
        }

        private string climate;
        public string Climate
        {
            get { return climate; }
            set { climate = value; }
        }

        public Location(string cityNameArg, string regionNameArg, string climateArg = "NA")
        {
            CityName = cityNameArg;
            RegionName = regionNameArg;
            Climate = climateArg;
        }
        public string PrintRegionDetails()
        {
            return ($"You are in {cityName} in the region of {regionName}. Test:{climate}");
        }
    }
}
