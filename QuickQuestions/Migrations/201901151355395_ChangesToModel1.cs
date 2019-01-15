namespace QuickQuestions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Answer", "AnswerText", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Answer", "AnswerText", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
