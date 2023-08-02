using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeedGUI.Environment
{
    public static class CityandRegionObjects
    {

        static Location Wugrad = new Location("Wugrad", "Offer", "Cold");
        static Location Barjarn = new Location("Barjarn", "Offer", "Cold");
        static Location Dawnridge = new Location("Dawnridge", "Kellrahn");

        /* I know I KNOW there's a better way to do this class but it's not coming to me. maybe a list or array of the objects?

        //public static List<Location> locationsList = new List<Location>()
        //{
        //    Wugrad, Barjarn, Dawnridge
        //};
         string locationDetails = locationsList[1].PrintRegionDetails();

        this is the part I need to reconsider ▼ . I dont want to make a "deats" variable for every single object, but I can't call a method on 
         any old variable. I need to figure out how to call this method on different inputs without listing every single one out all the time.*/

        static string wugradDeats = Wugrad.PrintRegionDetails();
        static string barjarnDeats = Barjarn.PrintRegionDetails();
        static string dawnridgeDeats = Dawnridge.PrintRegionDetails();

        public static void GiveCityDetails(string city)
        {
            if (city == "Wugrad")
                ShopWindow.locationLabel.Text = wugradDeats;
            else if (city == "Barjarn")
                ShopWindow.locationLabel.Text = barjarnDeats;
            else
                ShopWindow.locationLabel.Text = dawnridgeDeats;
        }
    }
}
