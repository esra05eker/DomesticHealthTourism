namespace DHT.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DHT.Data.DhtContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DHT.Data.DhtContext";
        }

        protected override void Seed(DHT.Data.DhtContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if(context.SysAdmins.Where(a => a.Email == "a@b.com").FirstOrDefault() == null)
            {
                context.SysAdmins.Add(new Entity.Entities.SysAdmin()
                {
                    Email = "a@b.com",
                    Password = "202CB962AC59075B964B07152D234B70",
                    Firstname = "Elif",
                    Lastname = "Elif"
                });
            }
        }
    }
}
