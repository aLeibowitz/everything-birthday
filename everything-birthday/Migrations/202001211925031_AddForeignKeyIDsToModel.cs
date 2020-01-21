namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyIDsToModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.EventEntries", name: "Day_DayId", newName: "DayId");
            RenameColumn(table: "dbo.EventEntries", name: "EventType_EventTypeId", newName: "EventTypeId");
            RenameColumn(table: "dbo.EventEntries", name: "Month_MonthId", newName: "MonthId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_EventType_EventTypeId", newName: "IX_EventTypeId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_Month_MonthId", newName: "IX_MonthId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_Day_DayId", newName: "IX_DayId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.EventEntries", name: "IX_DayId", newName: "IX_Day_DayId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_MonthId", newName: "IX_Month_MonthId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_EventTypeId", newName: "IX_EventType_EventTypeId");
            RenameColumn(table: "dbo.EventEntries", name: "MonthId", newName: "Month_MonthId");
            RenameColumn(table: "dbo.EventEntries", name: "EventTypeId", newName: "EventType_EventTypeId");
            RenameColumn(table: "dbo.EventEntries", name: "DayId", newName: "Day_DayId");
        }
    }
}
