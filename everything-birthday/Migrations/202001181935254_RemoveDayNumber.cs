namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDayNumber : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Days", "DayNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Days", "DayNumber", c => c.String());
        }
    }
}
