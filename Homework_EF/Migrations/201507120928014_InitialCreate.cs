namespace Homework_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Category_Id = c.Int(),
                        Test_TestId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Tests", t => t.Test_TestId)
                .Index(t => t.Category_Id)
                .Index(t => t.Test_TestId);
            
            CreateTable(
                "dbo.TestResults",
                c => new
                    {
                        TestId = c.Int(nullable: false),
                        TimeTaken = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.TestId)
                .ForeignKey("dbo.Tests", t => t.TestId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.TestId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GivenTime = c.Int(nullable: false),
                        PassingScore = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.TestId)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        University = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.TeacherLectures",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        Lecture_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.Lecture_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.Lectures", t => t.Lecture_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Lecture_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TestResults", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.TestResults", "TestId", "dbo.Tests");
            DropForeignKey("dbo.Questions", "Test_TestId", "dbo.Tests");
            DropForeignKey("dbo.Tests", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Questions", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.TeacherLectures", "Lecture_Id", "dbo.Lectures");
            DropForeignKey("dbo.TeacherLectures", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Lectures", "Category_Id", "dbo.Categories");
            DropIndex("dbo.TeacherLectures", new[] { "Lecture_Id" });
            DropIndex("dbo.TeacherLectures", new[] { "Teacher_Id" });
            DropIndex("dbo.Users", new[] { "Category_Id" });
            DropIndex("dbo.Tests", new[] { "Category_Id" });
            DropIndex("dbo.TestResults", new[] { "User_UserId" });
            DropIndex("dbo.TestResults", new[] { "TestId" });
            DropIndex("dbo.Questions", new[] { "Test_TestId" });
            DropIndex("dbo.Questions", new[] { "Category_Id" });
            DropIndex("dbo.Lectures", new[] { "Category_Id" });
            DropTable("dbo.TeacherLectures");
            DropTable("dbo.Users");
            DropTable("dbo.Tests");
            DropTable("dbo.TestResults");
            DropTable("dbo.Questions");
            DropTable("dbo.Teachers");
            DropTable("dbo.Lectures");
            DropTable("dbo.Categories");
        }
    }
}
