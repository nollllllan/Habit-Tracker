namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoomsTableAndMembership : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Habits", "UserId", "dbo.Users");
            DropIndex("dbo.Habits", new[] { "UserId" });
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomMemberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoomId);
            
            AddColumn("dbo.Habits", "RoomId", c => c.Int(nullable: true));
            AlterColumn("dbo.Habits", "UserId", c => c.Int(nullable: true));
            CreateIndex("dbo.Habits", "UserId");
            CreateIndex("dbo.Habits", "RoomId");
            AddForeignKey("dbo.Habits", "RoomId", "dbo.Rooms", "Id");
            AddForeignKey("dbo.Habits", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Habits", "UserId", "dbo.Users");
            DropForeignKey("dbo.RoomMemberships", "UserId", "dbo.Users");
            DropForeignKey("dbo.RoomMemberships", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Habits", "RoomId", "dbo.Rooms");
            DropIndex("dbo.RoomMemberships", new[] { "RoomId" });
            DropIndex("dbo.RoomMemberships", new[] { "UserId" });
            DropIndex("dbo.Habits", new[] { "RoomId" });
            DropIndex("dbo.Habits", new[] { "UserId" });
            AlterColumn("dbo.Habits", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Habits", "RoomId");
            DropTable("dbo.RoomMemberships");
            DropTable("dbo.Rooms");
            CreateIndex("dbo.Habits", "UserId");
            AddForeignKey("dbo.Habits", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
