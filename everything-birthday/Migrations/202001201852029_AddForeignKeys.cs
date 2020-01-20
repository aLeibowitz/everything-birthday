namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EventEntries", "Day_DayId", "dbo.Days");
            DropForeignKey("dbo.EventEntries", "EventType_EventTypeId", "dbo.EventTypes");
            DropForeignKey("dbo.EventEntries", "Month_MonthId", "dbo.Months");
            DropIndex("dbo.EventEntries", new[] { "Day_DayId" });
            DropIndex("dbo.EventEntries", new[] { "EventType_EventTypeId" });
            DropIndex("dbo.EventEntries", new[] { "Month_MonthId" });
            AlterColumn("dbo.EventEntries", "CelebrantName", c => c.String(nullable: false));
            DropColumn("dbo.EventEntries", "Day_DayId");
            DropColumn("dbo.EventEntries", "EventType_EventTypeId");
            DropColumn("dbo.EventEntries", "Month_MonthId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventEntries", "Month_MonthId", c => c.Int());
            AddColumn("dbo.EventEntries", "EventType_EventTypeId", c => c.Int());
            AddColumn("dbo.EventEntries", "Day_DayId", c => c.Int());
            AlterColumn("dbo.EventEntries", "CelebrantName", c => c.String());
            CreateIndex("dbo.EventEntries", "Month_MonthId");
            CreateIndex("dbo.EventEntries", "EventType_EventTypeId");
            CreateIndex("dbo.EventEntries", "Day_DayId");
            AddForeignKey("dbo.EventEntries", "Month_MonthId", "dbo.Months", "MonthId");
            AddForeignKey("dbo.EventEntries", "EventType_EventTypeId", "dbo.EventTypes", "EventTypeId");
            AddForeignKey("dbo.EventEntries", "Day_DayId", "dbo.Days", "DayId");
        }
    }
}
