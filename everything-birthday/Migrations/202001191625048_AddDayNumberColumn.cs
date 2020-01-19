namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDayNumberColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Days", "DayNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Days", "DayNumber");
        }
    }
}
