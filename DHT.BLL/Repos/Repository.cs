using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity; //for dbcontext
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public abstract class Repository<TEntity> where TEntity : BaseEntity // TEntity öyle bir nesnedir ki BaseEntity'den türer
    {
        // tablodan ilgili id ile ilgili entity getir
        public static TEntity Get(int id)
        {
            using (var db = new DhtContext())
            {
                return db.Set<TEntity>().Where(a => a.Id == id).FirstOrDefault();
            }
        }

        // tablolara çoklu insert ve update işlemleri
        public static int InsertOrUpdateAll(ICollection<TEntity> entities)
        {
            if (entities == null) return 0; // null ise geğişiklik yapılamadı anlamında 0 değeri gönderiliyor

            using (var db = new DhtContext())
            {
                foreach (var entity in entities)
                {
                    // öncelikle gelen verinin id bilgisine göre veritabanında arama yapıyoruz eğer var ise güncelleme, yok ise insert işlemi yapılacak
                    var found = db.Set<TEntity>().Where(d => d.Id == entity.Id).FirstOrDefault();
                    if (found != null)
                    {
                        // güncelleme yapılabilmesi için bulduğumuz kaydın verilerini yeni verilerle güncelliyoruz
                        db.Entry(found).CurrentValues.SetValues(entity);
                    }
                    else
                    {
                        // eklenecekler listesine ekledik
                        db.Set<TEntity>().Add(entity);
                    }
                }

                // işlemi gerçekleştir
                return db.SaveChanges();
            }
        }

        // tablolara insert ve update işlemi
        public static int InsertOrUpdate(TEntity entity)
        {
            if (entity == null) return 0; // null ise değişiklik yapılamadı anlamında 0 değeri gönderiliyor

            using (var db = new DhtContext())
            {
                // öncelikle gelen verinini id bilgisine göre veritabanında arama yapıyoruz eğer var ise güncelleme ,yok ise insert işlemi yapılacak
                var found = db.Set<TEntity>().Where(d => d.Id == entity.Id)
                    .FirstOrDefault(); // ilk kaydı al bulamazsan null döndür

                if (found != null)
                {
                    // güncelleme yapılabilmesi için bulduğumuz kayıdın verileri yeni verilerle güncelliyoruz
                    db.Entry(found).CurrentValues.SetValues(entity);
                }
                else
                {
                    // eklenecekler listesine ekledik
                    db.Set<TEntity>()
                        .Add(entity); // ekle
                }

                // işlemi gerçekleştir
                // yapılan işlemleri kaydet
                return db.SaveChanges();
            }
        }

        // tablodan veri silmek için
        public static int Delete(TEntity entity)
        {
            using (var db = new DhtContext())
            {
                // kaydı bul
                var entry = db.Entry(entity);
                if (entry.State == EntityState.Detached) // kayıt takip edilmiyorsa takip etmeye başla
                    db.Set<TEntity>().Attach(entity); // kümene dahil et, izlemeye başla aksi takdirde EF ben bu nesneyi tanımıyorum şeklinde hata verirdi

                // kaydı silinecek olarak işaretler
                db.Set<TEntity>()
                    .Remove(entity); // sil

                // işlemi gerçekleştir
                // yapılan işlemleri kaydet
                return db.SaveChanges();
            }
        }

    }
}
