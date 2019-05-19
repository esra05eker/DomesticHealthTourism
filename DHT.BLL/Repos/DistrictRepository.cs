using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class DistrictRepository : Repository<District>
    {
        // ilçeleri getirir
        public static List<District> GetDistricts()
        {
            using (var db = new DhtContext())
            {
                return db.Districts.OrderBy(a => a.Name).ToList();
            }
        }

        // sadece belirli ilin ilçelerini getirir
        public static List<District> GetCityDistricts(int cityId)
        {

            using (var db = new DhtContext())
            {
                return db.Districts
                    .Where(a => a.CityId == cityId)
                    .OrderBy(a => a.Name)
                    .ToList();
            }

        }



    }
}
