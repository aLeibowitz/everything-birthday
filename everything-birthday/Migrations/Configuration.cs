namespace everything_birthday.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using everything_birthday.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            SeedEventTypeTable(context);
            SeedMonthTable(context);
            SeedDayTable(context);
        }

        private static void SeedEventTypeTable(ApplicationDbContext context)
        {
            context.EventTypes.AddOrUpdate(e => e.EventTypeName,
                new EventType { EventTypeName = "birthday"},
                new EventType { EventTypeName = "wedding anniversary"},
                new EventType { EventTypeName = "special day"}
                );
        }

        private static void SeedMonthTable(ApplicationDbContext context)
        {
            context.Months.AddOrUpdate(m => m.MonthName,
                new Month { MonthName = "January" },
                new Month { MonthName = "February" },
                new Month { MonthName = "March" },
                new Month { MonthName = "April" },
                new Month { MonthName = "May" },
                new Month { MonthName = "June" },
                new Month { MonthName = "July" },
                new Month { MonthName = "August" },
                new Month { MonthName = "September" },
                new Month { MonthName = "October" },
                new Month { MonthName = "November" },
                new Month { MonthName = "December" }
                );
        }

        private static void SeedDayTable(ApplicationDbContext context)
        {
            context.Days.AddOrUpdate(d => d.DayNumber,
                new Day { DayNumber = 1 },
                new Day { DayNumber = 2 },
                new Day { DayNumber = 3 },
                new Day { DayNumber = 4 },
                new Day { DayNumber = 5 },
                new Day { DayNumber = 6 },
                new Day { DayNumber = 7 },
                new Day { DayNumber = 8 },
                new Day { DayNumber = 9 },
                new Day { DayNumber = 10 },
                new Day { DayNumber = 11 },
                new Day { DayNumber = 12 },
                new Day { DayNumber = 13 },
                new Day { DayNumber = 14 },
                new Day { DayNumber = 15 },
                new Day { DayNumber = 16 },
                new Day { DayNumber = 17 },
                new Day { DayNumber = 18 },
                new Day { DayNumber = 19 },
                new Day { DayNumber = 20 },
                new Day { DayNumber = 21 },
                new Day { DayNumber = 22 },
                new Day { DayNumber = 23 },
                new Day { DayNumber = 24 },
                new Day { DayNumber = 25 },
                new Day { DayNumber = 26 },
                new Day { DayNumber = 27 },
                new Day { DayNumber = 28 },
                new Day { DayNumber = 29 },
                new Day { DayNumber = 30 },
                new Day { DayNumber = 31 }
                );
        }
    }
}
