using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CourseOne.Models;
using CourseOne.Repository;
using CourseOne.Context;

namespace CourseOne.Repository
{
    
    public class CourseRepository : ICourse
    {
        private DatabaseContext databaseContext;

        public CourseRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public IEnumerable<Course> listCourse()
        {
            return databaseContext.Courses.ToList();
        }
    }
}