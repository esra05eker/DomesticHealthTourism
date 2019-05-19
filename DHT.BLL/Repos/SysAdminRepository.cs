using DHT.Data;
using DHT.Entity.Entities;
using DHT.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class SysAdminRepository : Repository<SysAdmin>
    {
        // sistem yöneticilerini getirir
        public static List<SysAdmin> GetSysAdmins()
        {
            using (var db = new DhtContext())
            {
                return db.SysAdmins
                    .ToList();
            }
        }

        // sistem yöneticisi giriş işlemi bilgiler doğru mu kontrol eder
        public static bool Login(string username, string password)
        {
            using (var db = new DhtContext())
            {
                password = StringUtils.MD5(password);
                return db.SysAdmins
                    .Where(x => x.Email == username && x.Password == password)
                    .Any(); // any şartlara uyan herhangi bir kayıt var mı?
            }
        }
    }
}
