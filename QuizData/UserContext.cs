using System.Data.Entity;

namespace QuizData
{

    public class UserContext : DbContext
    {
        public UserContext(): base("name=UserDBConnectionString")  {
            Database.SetInitializer(new CreateDatabaseIfNotExists<UserContext>());
        }
        public DbSet<UserData> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here

            base.OnModelCreating(modelBuilder);
        }
    }
}
