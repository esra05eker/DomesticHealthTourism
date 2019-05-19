namespace DHT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appoinments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppointmentTime = c.DateTime(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TcNo = c.String(nullable: false, maxLength: 11),
                        Firstname = c.String(nullable: false, maxLength: 100),
                        Lastname = c.String(nullable: false, maxLength: 100),
                        Gender = c.Int(nullable: false),
                        Email = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 15),
                        HospitalClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HospitalClinics", t => t.HospitalClinicId, cascadeDelete: true)
                .Index(t => t.TcNo, unique: true)
                .Index(t => t.HospitalClinicId);
            
            CreateTable(
                "dbo.HospitalClinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HospitalId = c.Int(nullable: false),
                        ClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinics", t => t.ClinicId, cascadeDelete: true)
                .ForeignKey("dbo.Hospitals", t => t.HospitalId, cascadeDelete: true)
                .Index(t => t.HospitalId)
                .Index(t => t.ClinicId);
            
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(maxLength: 15),
                        Address = c.String(nullable: false, maxLength: 255),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TcNo = c.String(nullable: false, maxLength: 11),
                        Password = c.String(nullable: false, maxLength: 50),
                        Firstname = c.String(nullable: false, maxLength: 100),
                        Lastname = c.String(nullable: false, maxLength: 100),
                        Gender = c.Int(nullable: false),
                        Email = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.TcNo, unique: true);
            
            CreateTable(
                "dbo.HospitalClinicExaminations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HospitalClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HospitalClinics", t => t.HospitalClinicId, cascadeDelete: true)
                .Index(t => t.HospitalClinicId);
            
            CreateTable(
                "dbo.SysAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 11),
                        Password = c.String(nullable: false, maxLength: 50),
                        Firstname = c.String(nullable: false, maxLength: 100),
                        Lastname = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HospitalClinicExaminations", "HospitalClinicId", "dbo.HospitalClinics");
            DropForeignKey("dbo.Appoinments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Hospitals", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Districts", "CityId", "dbo.Cities");
            DropForeignKey("dbo.HospitalClinics", "HospitalId", "dbo.Hospitals");
            DropForeignKey("dbo.Doctors", "HospitalClinicId", "dbo.HospitalClinics");
            DropForeignKey("dbo.HospitalClinics", "ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.Appoinments", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.SysAdmins", new[] { "Email" });
            DropIndex("dbo.HospitalClinicExaminations", new[] { "HospitalClinicId" });
            DropIndex("dbo.Patients", new[] { "TcNo" });
            DropIndex("dbo.Cities", new[] { "Code" });
            DropIndex("dbo.Districts", new[] { "CityId" });
            DropIndex("dbo.Hospitals", new[] { "DistrictId" });
            DropIndex("dbo.HospitalClinics", new[] { "ClinicId" });
            DropIndex("dbo.HospitalClinics", new[] { "HospitalId" });
            DropIndex("dbo.Doctors", new[] { "HospitalClinicId" });
            DropIndex("dbo.Doctors", new[] { "TcNo" });
            DropIndex("dbo.Appoinments", new[] { "DoctorId" });
            DropIndex("dbo.Appoinments", new[] { "PatientId" });
            DropTable("dbo.SysAdmins");
            DropTable("dbo.HospitalClinicExaminations");
            DropTable("dbo.Patients");
            DropTable("dbo.Cities");
            DropTable("dbo.Districts");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Clinics");
            DropTable("dbo.HospitalClinics");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appoinments");
        }
    }
}
