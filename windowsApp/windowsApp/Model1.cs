namespace windowsApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using windowsApp.Model;
    

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'windowsApp.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("Data Source=.;Initial Catalog=univercityDB;trusted_connection=true")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<Model1>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Model1, windowsApp.Migrations.Configuration>());
        }
        
        
        public DbSet<person> persons { get; set; }
        public DbSet<student> students { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<major> majors { get; set; }
        public DbSet<course> courses { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}