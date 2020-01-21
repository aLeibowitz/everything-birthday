namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedToSingularFormInModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.EventEntries", name: "Days_DayId", newName: "Day_DayId");
            RenameColumn(table: "dbo.EventEntries", name: "EventTypes_EventTypeId", newName: "EventType_EventTypeId");
            RenameColumn(table: "dbo.EventEntries", name: "Months_MonthId", newName: "Month_MonthId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_Days_DayId", newName: "IX_Day_DayId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_EventTypes_EventTypeId", newName: "IX_EventType_EventTypeId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_Months_MonthId", newName: "IX_Month_MonthId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.EventEntries", name: "IX_Month_MonthId", newName: "IX_Months_MonthId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_EventType_EventTypeId", newName: "IX_EventTypes_EventTypeId");
            RenameIndex(table: "dbo.EventEntries", name: "IX_Day_DayId", newName: "IX_Days_DayId");
            RenameColumn(table: "dbo.EventEntries", name: "Month_MonthId", newName: "Months_MonthId");
            RenameColumn(table: "dbo.EventEntries", name: "EventType_EventTypeId", newName: "EventTypes_EventTypeId");
            RenameColumn(table: "dbo.EventEntries", name: "Day_DayId", newName: "Days_DayId");
        }
    }
}
