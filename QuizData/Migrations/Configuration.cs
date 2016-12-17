namespace QuizData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.User.AddOrUpdate(
              u => u.Id,
              new UserData { FirstName = "Andrew", LastName = "Peters", Email = "apeters@test.com", DateOfBirth = "04/11/1980", Salary = 65000 },
              new UserData { FirstName = "Brice", LastName = "Lambson", Email = "blambson@test.com", DateOfBirth = "17/08/1975", Salary = 75000 },
              new UserData { FirstName = "Rowan", LastName = "Miller", Email = "rmiller@test.com", DateOfBirth = "25/01/1990}", Salary = 50000 }
            );

        }
    }
}
