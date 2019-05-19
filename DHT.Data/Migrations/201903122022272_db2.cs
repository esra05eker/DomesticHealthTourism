namespace DHT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SysAdmins", new[] { "Email" });
            AlterColumn("dbo.SysAdmins", "Email", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.SysAdmins", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.SysAdmins", new[] { "Email" });
            AlterColumn("dbo.SysAdmins", "Email", c => c.String(nullable: false, maxLength: 11));
            CreateIndex("dbo.SysAdmins", "Email", unique: true);
        }
    }
}
