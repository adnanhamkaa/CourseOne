using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CourseOne.Models;


namespace CourseOne.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=DESKTOP-2BFFTTP;Initial Catalog=SchoolDB;integrated security=True;user id=sa;password=P@ssw0rd;")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext,
               CourseOne.Migrations.Configuration>());
        }

        public virtual System.Data.Entity.DbSet<CourseOne.Models.Student> Students { get; set; }

        public virtual System.Data.Entity.DbSet<CourseOne.Models.Teacher> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}