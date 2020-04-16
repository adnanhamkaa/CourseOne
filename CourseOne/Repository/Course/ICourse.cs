using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseOne.Models;

namespace CourseOne.Repository
{
    interface ICourse
    {
        IEnumerable<Course> listCourse();
    }
}
