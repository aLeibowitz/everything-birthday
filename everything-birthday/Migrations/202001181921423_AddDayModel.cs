namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDayModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        DayId = c.Int(nullable: false, identity: true),
                        DayNumber = c.String(),
                    })
                .PrimaryKey(t => t.DayId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Days");
        }
    }
}
