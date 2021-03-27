namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHabbitTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NowResult = c.Int(nullable: false),
                        GoalResult = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Habits", "UserId", "dbo.Users");
            DropIndex("dbo.Habits", new[] { "UserId" });
            DropTable("dbo.Habits");
        }
    }
}
