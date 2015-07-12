namespace Homework_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Answer_Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        TestResult_TestId = c.Int(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestResults", t => t.TestResult_TestId)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.TestResult_TestId)
                .Index(t => t.Question_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Answers", "TestResult_TestId", "dbo.TestResults");
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropIndex("dbo.Answers", new[] { "TestResult_TestId" });
            DropTable("dbo.Answers");
        }
    }
}
