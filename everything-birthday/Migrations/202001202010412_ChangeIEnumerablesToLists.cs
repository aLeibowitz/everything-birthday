namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIEnumerablesToLists : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventEntries", "Days_DayId", c => c.Int(nullable: false));
            AddColumn("dbo.EventEntries", "EventTypes_EventTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.EventEntries", "Months_MonthId", c => c.Int(nullable: false));
            CreateIndex("dbo.EventEntries", "Days_DayId");
            CreateIndex("dbo.EventEntries", "EventTypes_EventTypeId");
            CreateIndex("dbo.EventEntries", "Months_MonthId");
            AddForeignKey("dbo.EventEntries", "Days_DayId", "dbo.Days", "DayId", cascadeDelete: true);
            AddForeignKey("dbo.EventEntries", "EventTypes_EventTypeId", "dbo.EventTypes", "EventTypeId", cascadeDelete: true);
            AddForeignKey("dbo.EventEntries", "Months_MonthId", "dbo.Months", "MonthId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventEntries", "Months_MonthId", "dbo.Months");
            DropForeignKey("dbo.EventEntries", "EventTypes_EventTypeId", "dbo.EventTypes");
            DropForeignKey("dbo.EventEntries", "Days_DayId", "dbo.Days");
            DropIndex("dbo.EventEntries", new[] { "Months_MonthId" });
            DropIndex("dbo.EventEntries", new[] { "EventTypes_EventTypeId" });
            DropIndex("dbo.EventEntries", new[] { "Days_DayId" });
            DropColumn("dbo.EventEntries", "Months_MonthId");
            DropColumn("dbo.EventEntries", "EventTypes_EventTypeId");
            DropColumn("dbo.EventEntries", "Days_DayId");
        }
    }
}
