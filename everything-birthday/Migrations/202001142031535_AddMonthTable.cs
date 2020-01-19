namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMonthTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Months",
                c => new
                    {
                        MonthId = c.Int(nullable: false, identity: true),
                        MonthName = c.String(),
                    })
                .PrimaryKey(t => t.MonthId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Months");
        }
    }
}
