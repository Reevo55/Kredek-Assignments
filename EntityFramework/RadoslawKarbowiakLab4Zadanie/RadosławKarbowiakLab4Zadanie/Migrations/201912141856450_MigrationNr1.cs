namespace RadosławKarbowiakLab4Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationNr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Institutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Speciality = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        InstitutionId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institutions", t => t.InstitutionId, cascadeDelete: true)
                .Index(t => t.InstitutionId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Disease = c.String(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        InstitutionId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institutions", t => t.InstitutionId, cascadeDelete: true)
                .Index(t => t.InstitutionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "InstitutionId", "dbo.Institutions");
            DropForeignKey("dbo.Patients", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "InstitutionId", "dbo.Institutions");
            DropForeignKey("dbo.Institutions", "CityId", "dbo.Cities");
            DropIndex("dbo.Staffs", new[] { "InstitutionId" });
            DropIndex("dbo.Patients", new[] { "DoctorId" });
            DropIndex("dbo.Doctors", new[] { "InstitutionId" });
            DropIndex("dbo.Institutions", new[] { "CityId" });
            DropTable("dbo.Staffs");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
            DropTable("dbo.Institutions");
            DropTable("dbo.Cities");
        }
    }
}
