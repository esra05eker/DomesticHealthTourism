using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class CityRepository : Repository<City>
    {
        // şehirleri getirir
        public static List<City> GetCities()
        {
            using (var db = new DhtContext())
            {
                return db.Cities
                    .Include("Districts")
                    .OrderBy(a => a.Code)
                    .ToList();
            }
        }


    }
}
