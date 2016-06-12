using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    using dk.gls.www;
    public class Controller
    {
        dk.gls.www.ParcelShopSearchResult result;
        dk.gls.www.wsShopFinder finder;
        List<PakkeshopData> shops;

        public Controller()
        {
            finder = new wsShopFinder();            
        }

        public void SearchNearestParcelShops(string street, string postCode, string countryCode, int amount)
        {
            shops = new List<PakkeshopData>();

            result = finder.SearchNearestParcelShops(street, postCode, countryCode, amount);
            for (int i = 0; i < result.parcelshops.Length; i++)
            {
                shops.Add(result.parcelshops[i]);                
            }
        }

        public int ReturnCount()
        {
            return shops.Count;
        }

        public PakkeshopData GetShop(int index)
        {
            return shops[index];
        }
    }
}
