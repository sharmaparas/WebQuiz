namespace QuizData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDatas", "DateOfBirth", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDatas", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
