namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBirthdayToEvent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventEntries",
                c => new
                    {
                        EventEntryId = c.Int(nullable: false, identity: true),
                        CelebrantName = c.String(),
                        Year = c.Int(),
                        Deleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        ApplicationUserId = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        Day_DayId = c.Int(),
                        EventType_EventTypeId = c.Int(),
                        Month_MonthId = c.Int(),
                    })
                .PrimaryKey(t => t.EventEntryId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Days", t => t.Day_DayId)
                .ForeignKey("dbo.EventTypes", t => t.EventType_EventTypeId)
                .ForeignKey("dbo.Months", t => t.Month_MonthId)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Day_DayId)
                .Index(t => t.EventType_EventTypeId)
                .Index(t => t.Month_MonthId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventEntries", "Month_MonthId", "dbo.Months");
            DropForeignKey("dbo.EventEntries", "EventType_EventTypeId", "dbo.EventTypes");
            DropForeignKey("dbo.EventEntries", "Day_DayId", "dbo.Days");
            DropForeignKey("dbo.EventEntries", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.EventEntries", new[] { "Month_MonthId" });
            DropIndex("dbo.EventEntries", new[] { "EventType_EventTypeId" });
            DropIndex("dbo.EventEntries", new[] { "Day_DayId" });
            DropIndex("dbo.EventEntries", new[] { "ApplicationUser_Id" });
            DropTable("dbo.EventEntries");
        }
    }
}
