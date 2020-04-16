using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CourseOne.Context
{
    public class DatabaseContext : DbContext
    {
        public System.Data.Entity.DbSet<CourseOne.Models.Student> Students { get; set; }
    }
}